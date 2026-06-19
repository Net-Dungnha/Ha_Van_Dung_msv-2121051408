import pandas as pd
import numpy as np
from sklearn.ensemble import RandomForestClassifier
from sklearn.model_selection import train_test_split
from sklearn.metrics import accuracy_score
import joblib
import os

# Đọc data đã xử lý
input_dir = "/opt/ml/input/data/train"
output_dir = "/opt/ml/model"
os.makedirs(output_dir, exist_ok=True)

# Load data
dfs = []
for file in os.listdir(input_dir):
    if file.endswith(".csv"):
        dfs.append(pd.read_csv(f"{input_dir}/{file}"))
df = pd.concat(dfs)

# Tách features và label
# ⚠️ Thay 'target' bằng tên cột label thật trong data của bạn
X = df.drop("target", axis=1)
y = df["target"]

# Train/test split
X_train, X_test, y_train, y_test = train_test_split(
    X, y, test_size=0.2, random_state=42
)

# Train model
model = RandomForestClassifier(n_estimators=100, random_state=42)
model.fit(X_train, y_train)

# Đánh giá
acc = accuracy_score(y_test, model.predict(X_test))
print(f"Accuracy: {acc:.4f}")

# Lưu model
joblib.dump(model, f"{output_dir}/model.joblib")
print("Model đã được lưu!")