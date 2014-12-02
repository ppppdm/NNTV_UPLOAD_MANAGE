# coding=gbk
from datetime import datetime,date,time
import os
from ftplib import FTP

def copyfiles(sourcedir,targetdir):
    os.makedirs(targetdir)
    for f in os.listdir(sourcedir):
        sourceFile = os.path.join(sourcedir,f)
        targetFile = os.path.join(targetdir,f)
        if os.path.isdir(sourceFile):
            copyfiles(sourceFile,targetFile)
        if os.path.isfile(sourceFile):
            infile = open(sourceFile,"rb")
            outfile = open(targetFile,"wb")
            outfile.write(infile.read())
            infile.close()
            outfile.close()

def filesToFtp(sourcedir,targetdir,ftp):
    ftp.mkd(targetdir)
    ftp.cwd(targetdir)
    for f in os.listdir(sourcedir):
        sourceFile = os.path.join(sourcedir,f)
        targetFile = f
        if os.path.isdir(sourceFile):
            filesToFtp(sourceFile,targetFile,ftp)
            ftp.cwd("..")
        if os.path.isfile(sourceFile):
            infile = open(sourceFile,"rb") 
            ftp.storbinary("STORE " + targetFile, infile.read())
            infile.close()
            
            
if __name__=="__main__":
    #--输出到文件系统--
    #输入文件夹
    IN_DIR="../SETUP_UPLOAD_PROCESS_SUPERVISION/Release"
    #输出文件夹
    OUT_DIR="Z:/"
    OUT_DIR_PREFIX = "nntv_ps-"
    
    t = datetime.now()
    print(t.strftime("%Y%m%d%H%M"))
    OUT_DIR_SUFFIX = t.strftime("%Y%m%d%H%M")
    OUT_DIR += OUT_DIR_PREFIX + OUT_DIR_SUFFIX
    
    copyfiles(IN_DIR,OUT_DIR)
    
    #输出到FTP服务器
    ftp = FTP("192.168.5.252")
    ftp.login()
    filesToFtp(IN_DIR, OUT_DIR_PREFIX + OUT_DIR_SUFFIX, ftp)
    #ftp.storbinary("STORE 1111.TXT", open("D:/1111.txt","rb"))
    ftp.retrlines('LIST nntv*')
    ftp.quit()
