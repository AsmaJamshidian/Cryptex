
# VigiEmotion - Real-Time Face Emotion Detection & Security Alert System

VigiEmotion is an AI-powered application that performs real-time face detection, emotion, age, and gender analysis using your webcam. It recognizes known individuals and instantly sends alerts via Telegram with snapshots of unknown persons—bringing smart surveillance to your fingertips.

---

## Features

- 🎥 Real-time face detection using webcam  
- 🧠 Emotion, age, and gender recognition powered by DeepFace  
- 🔍 Face recognition of known individuals  
- 🚨 Automatic Telegram alerts with snapshots of unknown faces  
- 📊 Logs detections in CSV format with timestamps  
- 📂 Organized folders for known and unknown face images  

---

## How It Works

1. Captures live video from your webcam  
2. Detects faces and analyzes emotions, age, and gender  
3. Compares faces against a database of known people  
4. Saves and sends snapshots of unknown individuals via Telegram  
5. Logs all detections with relevant details  

---

## Project Structure

```plaintext
VigiEmotion/
├── main.py               # Core script  
├── requirements.txt      # Dependencies  
├── known/                # Known faces images  
```

---

## Prerequisites

- Python 3.7 or higher  
- Install dependencies from `requirements.txt`, including:  
  - `deepface`  
  - `opencv-python`  
  - `requests`  

---

## Setup & Usage

1. Clone the repository:

```bash
git clone https://github.com/yourusername/VigiEmotion.git
cd VigiEmotion
```

2. Add clear frontal images of known people into the `known/` folder.

3. Install dependencies:

```bash
pip install -r requirements.txt
```

4. Run the application:

```bash
python main.py
```

5. Press `q` to quit.

---

## Security & Privacy Notes

- Store sensitive credentials in `.env` and exclude it from version control.  
- Use clear frontal images for better recognition accuracy.  
- Telegram alerts include snapshots; consider privacy implications.  

---

## License

This project is licensed under the MIT License. See the [LICENSE](../LICENSE) file for details.

---


VigiEmotion combines AI-driven emotion recognition with real-time security alerts to provide a smart and reliable surveillance solution.
