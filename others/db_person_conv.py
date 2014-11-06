# coding=gbk

import pyodbc
dsn = "DRIVER={SQL SERVER};SERVER=USER-20140707NK\SQLEXPRESS;DATABASE=nntv_ps;UID=sa;PWD=nntv"
db = pyodbc.connect(dsn)

cursor = db.cursor()

f = open("1.txt")

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
	cursor.execute("if not exists (select * from person where id = ?) insert into person (name,telephone,department,id) values(?,?,?,?)", id, name, phone, department, id)
	cursor.commit()
	

f.close()



#cursor.execute("select * from tape")

'''
for i in cursor.fetchall():
	print(i)
'''

