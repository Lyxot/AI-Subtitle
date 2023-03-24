import time
import os.path
from pathlib import Path
 
import uvicorn
from fastapi import FastAPI, File, UploadFile
from starlette.responses import FileResponse
from fastapi.middleware.cors import CORSMiddleware

app = FastAPI()

app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)

@app.post("/file_upload")
async def file_upload(file: UploadFile = File(...)):
    start = time.time()
    try:
        res = await file.read()
        with open("/home/wwwroot/default/files/"+file.filename, "wb") as f:
            f.write(res)
        return {"message": "success", 'time': time.time() - start, 'filename': file.filename}
    except Exception as e:
        return {"message": str(e), 'time': time.time() - start, 'filename': file.filename}


if __name__ == '__main__':
    uvicorn.run(app=app, host="0.0.0.0", port=8000, workers=1)
