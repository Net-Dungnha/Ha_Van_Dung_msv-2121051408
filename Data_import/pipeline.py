import boto3
from sagemaker.workflow.pipeline import Pipeline
from sagemaker.workflow.steps import ProcessingStep, TrainingStep
from sagemaker.workflow.model_step import ModelStep
from sagemaker.sklearn.processing import SKLearnProcessor
from sagemaker.sklearn.estimator import SKLearn
from sagemaker.workflow.parameters import ParameterString
import sagemaker

# Setup
session = sagemaker.Session()
role = "arn:aws:iam::087706154459:role/marketing-ml-pipeline-sm-role"
region = "ap-southeast-1"

# Parameter — truyền vào khi chạy pipeline
input_data = ParameterString(
    name="InputData",
    default_value="s3://marketing-raw-data-087706154459/raw/"
)

# ── Bước 1: Processing ──
processor = SKLearnProcessor(
    framework_version="1.2-1",
    instance_type="ml.t3.medium",  # instance nhỏ, tiết kiệm chi phí
    instance_count=1,
    role=role
)

processing_step = ProcessingStep(
    name="ProcessData",
    processor=processor,
    inputs=[sagemaker.processing.ProcessingInput(
        source=input_data,
        destination="/opt/ml/processing/input"
    )],
    outputs=[sagemaker.processing.ProcessingOutput(
        source="/opt/ml/processing/output",
        destination="s3://marketing-ml-pipeline-processed-087706154459/processed/"
    )],
    code="processing.py"  # script xử lý data — tạo ở Bước 4
)

# ── Bước 2: Training ──
estimator = SKLearn(
    entry_point="train.py",  # script train — tạo ở Bước 4
    framework_version="1.2-1",
    instance_type="ml.m5.large",
    role=role,
    output_path="s3://marketing-ml-pipeline-results-087706154459/results/"
)

training_step = TrainingStep(
    name="TrainModel",
    estimator=estimator,
    inputs={
        "train": sagemaker.inputs.TrainingInput(
            s3_data="s3://marketing-ml-pipeline-processed/processed/",
            content_type="text/csv"
        )
    }
)

# ── Ghép các bước thành pipeline ──
pipeline = Pipeline(
    name="marketing-ml-pipeline-sm",
    parameters=[input_data],
    steps=[processing_step, training_step],
    sagemaker_session=session
)

# Tạo/cập nhật pipeline trên AWS
pipeline.upsert(role_arn=role)
print("Pipeline đã được tạo thành công!")