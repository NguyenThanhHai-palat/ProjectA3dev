import cv2
import numpy as np
from pyzbar.pyzbar import decode
import json
with open('data/code.json') as f:
    json_str = f.read()
json_obj = json.loads(json_str)
prev_value = None
cv2.namedWindow("CHECK QR VE")
cap = cv2.VideoCapture(0)
print("OpenCV-PythonMachine")
print("PALATDEV-APP_QR\n\n\n\n")
while True:
    ret, frame = cap.read()
    decoded_objs = decode(frame)
    cv2.imshow("CHECK QR VE", frame)
    for obj in decoded_objs:
        value = obj.data.decode('utf-8')
        if value == prev_value:
            print(" đã được quét trước đó.")
        elif value in json_obj.values():
            print(" hợp lệ.")
            prev_value = value
        else:
            print(" không hợp lệ.")
    if cv2.waitKey(1) == ord('q'):
        break
cap.release()
cv2.destroyAllWindows()