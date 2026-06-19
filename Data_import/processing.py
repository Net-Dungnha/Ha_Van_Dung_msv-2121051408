import pandas as pd
import os

# Đọc file từ S3 (SageMaker đã mount sẵn vào /opt/ml/processing/input)
input_dir = "/opt/ml/processing/input"
output_dir = "/opt/ml/processing/output"
os.makedirs(output_dir, exist_ok=True)

for file in os.listdir(input_dir):
    if file.endswith(".csv"):
        df = pd.read_csv(f"{input_dir}/{file}")
        
        # Làm sạch cơ bản
        df = df.dropna()                    # bỏ dòng thiếu dữ liệu
        df = df.drop_duplicates()           # bỏ dòng trùng lặp
        
        # Lưu ra output
        df.to_csv(f"{output_dir}/{file}", index=False)
        print(f"Đã xử lý: {file} — {len(df)} dòng")