# coding=gbk

f = open("1.txt")

import pyodbc
dsn = "DRIVER={SQL SERVER};SERVER=USER-20140707NK\SQLEXPRESS;DATABASE=nntv_ps;UID=sa;PWD=nntv"
db = pyodbc.connect(dsn)

cursor = db.cursor()

for line in f:
	line = line.strip()
	if line == "":
		break
	#print(line, end = '')
	
	arr = line.split(",")
	#print(arr)
	if arr[2]=='0':
		arr[2] = "播出部"
	else:
		arr[2] = "其他"
	print(arr)
	name = arr[0]
	phone = arr[1]
	department = arr[2]
	id = arr[3]
	
	if department == "播出部":
		inbc_send = True
		inbc_recv = True
		outbc_send = True
		outbc_recv = True
		upload = True
		checkup = True
		edit = True
		admin = True
	else:
		inbc_send = True
		inbc_recv = False
		outbc_send = False
		outbc_recv = False
		upload = False
		checkup = False
		edit = False
		admin = False
	
	cursor.execute("if not exists (select * from accessmanage where person_id = ?) insert into accessmanage (person_id,person_name,inbc_send,inbc_recv,outbc_send,outbc_recv,upload,checkup,edit,admin,department) values(?,?,?,?,?,?,?,?,?,?,?)", id,id,name,inbc_send,inbc_recv,outbc_send,outbc_recv,upload,checkup,edit,admin,department)
	cursor.commit()
	

f.close()