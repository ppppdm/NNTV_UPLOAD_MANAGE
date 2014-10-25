﻿Module GlobalValues
    Public Xuhao As Integer '用来表征项目的序号
    Public Declare Function CreateWnd Lib "MyDll" () As Double
    Public Declare Function CloseWnd Lib "MyDll" () As Double
    Public Declare Function ClearGraphs Lib "MyDll"() As Double
    Public Declare Function OnpStillCapture Lib "MyDll" _
        (ByVal hwnd As Long) As Double
    Public Declare Function InitStillGraph Lib "MyDll" _
        (ByVal hwnd As Long) As Double

    Public Declare Function CapDlgToFile Lib "MyDll" _
        (ByVal source_hwnd As Long, _
         ByVal picture_hwnd As Long, _
         ByVal thirds As Long) As Long
    Public Declare Function CapDlgTest Lib "MyDll" _
        (ByVal a As Long, _
         ByVal b As Long) As Integer
    Public Declare Function LoadBmpFileToStatic Lib "MyDll" _
        (ByVal a As Long, _
         ByVal b As Long, _
         ByVal c As Long, _
         ByVal d As Long, _
         ByVal e As Long) As Integer
    Public Declare Function EncBmpToJpg Lib "MyDll" _
        (ByVal filename_bmp As String, _
         ByVal filename_jpg As String) As Integer

    Public Declare Function Set_Upload_TimeCode Lib "APIHOOK_DLL" _
        (ByVal content As String, _
         ByRef timeBoxIndex As Integer) As Integer

    Public Declare Function Set_Button_Status Lib "APIHOOK_DLL" _
        (ByVal status As String, _
         ByVal buttonIndex As Integer) As Integer

    Public Declare Function Set_Edit_Str Lib "APIHOOK_DLL" _
        (ByVal content As String, _
         ByRef textBoxIndex As Integer) As Integer

    Public Declare Function Set_ComboBox Lib "APIHOOK_Dll" _
        (ByVal noUse As String, _
         ByRef selectIndex As Integer, _
         ByRef comboBoxIndex As Integer) As Integer

    Public Declare Function Set_ListView Lib "APIHOOK_Dll" _
        (ByRef a As Integer, _
        ByRef b As Integer, _
        ByRef c As Integer, _
        ByRef d As Integer) As Integer

    Public Declare Function Set_ListView_Str Lib "APIHOOK_Dll" _
        (ByVal a As String, _
        ByRef b As Integer, _
        ByRef c As Integer, _
        ByRef d As Integer) As Integer

    Public Declare Function GetCurrentThreadId Lib "kernel32" _
        Alias "GetCurrentThreadId" () As Integer

    Public Declare Function PostThreadMessage Lib "user32" _
        Alias "PostThreadMessageW" _
        (ByVal id As Integer, _
        ByVal wMsg As Integer, _
        ByRef wParam As Long, _
        ByRef lParam As Long) As Boolean

    Public Const WM_QUIT As Integer = &H12


    'Public Declare Sub Sleep Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Long)
    'Public ppid As Integer '用来表征项目编号，唯一标识
    'Public flag As Integer '用来表征是操作的第几步
    'Public upcutflag As Integer '用来表征上载截图是否按下
    'Public cutpicsrc As Integer '用来表征和截屏幕截图是否按下
    'Public pid As Integer '用来表征节目的序号，唯一标识
    'Public cutcount As Integer '用来表征截图按钮是否被按下，按下为1，没按下为0
    'Public cutcountsrc As Integer '用来表征屏幕截图按钮是否被按下，按下为1，没按下为0
    'Public updown As Integer  '用来表征点击“下一步”是第一次走还是通过点击“上一步”再点击的“下一步”，前者为0，后者为1
    'Public picflag As Integer '用来表征数据库中是否已有截图，如果有则为1，没有则为0.当其为1时，在点击“下一步”时，不用截图
    'Public lookflag = 1  '用来表征回看项目到哪一步了，默认为1，在第一步


    'tape, material状态(必须很数据库status表一致)
    Public StatusNotUpload As Integer = 1
    Public StatusNotCheckUp As Integer = 2   'haveUpload
    Public StatusHaveCheckUp As Integer = 3
    Public StatusUploading As Integer = 4
    Public StatusFailUpload As Integer = 5
    Public StatusCheckingUp As Integer = 6
    Public StatusFailCheckUp As Integer = 7
    Public StatusSendedOut As Integer = 8

    'jobType 需要与数据库中person表中的jobtype一致
    Public jobTypeRecvTape As Integer = 0

    '配置文件
    Public ConfigFile As String = "config.ini"
    Public CFUtil As ConfigFileUtil

    '数据库DB配置
    Public DbServer As String = "USER-20140707NK\SQLEXPRESS"
    Public DbDbNamme As String = "nntv_ps"
    Public DbUser As String = "sa"
    Public DbPawd As String = "nntv"
    Public ConnStr = ""

    '指纹机IP和端口
    Public FigurePrintIP As String = "192.168.5.155"
    Public FigurePrintPort As String = "4370"

    '是否使用摄像头
    Public UseCamera As Boolean = False

    '审核点设置,范围(0~100),对应数据库表格longset中相应的浮点数值
    'value[longset.column] * 100 = value[checkpoint]
    Public CheckPoint1 As Integer = Nothing '25
    Public CheckPoint2 As Integer = Nothing '50
    Public CheckPoint3 As Integer = Nothing '75

    '片头,片中,片尾审核时长
    Public CheckHeadLen As Integer = 30
    Public CheckMiddLen As Integer = 30
    Public CheckTailLen As Integer = 30

    '高级查询选项启用 Ao = advanced options
    Public AoNotUpdate As Boolean = True
    Public AoNotCheckUp As Boolean = True
    Public AoHadCheckUp As Boolean = False
    Public AoDateAndTime As Boolean = True

    '查询内容显示设置 Swo = show options
    'Public SwoTapeName = True ' not modify
    'Public SwoTapeStatus = True ' not modify

    'Public SwoTapeLength = True
    'Public SwoTapeSendInTime = True
    'Public SwoTapeSendInSendPer = False
    'Public SwoTapeSendInRecvPer = False
    'Public SwoTapeSendOutTime = True
    'Public SwoTapeSendOutSendPer = False
    'Public SwoTapeSendOutRecvPer = False

    '{"","","",bool} = {该变量名称, 数据库中的列名, 显示在dataGridView中的名字,用户配置是否显示该列}
    Public Const SwoName = 0
    Public Const SwoDbColumnName = 1
    Public Const SwoDataViewName = 2
    Public Const SwoValue = 3
    Public SwoTrueOptionsCount = 0 ' need be init or change if user change swo

    Public Swo As Object(,) = _
            {{"SwoTapeName", "tape_name", "名称", True}, _
             {"SwoTapeStatus", "tape_status", "状态", True}, _
             {"SwoTapeLength", "length", "时长", True}, _
             {"SwoTapeSendInTime", "in_bc_time", "送带时间", True}, _
             {"SwoTapeSendInSendPer", "in_bc_send_per", "送带人", False}, _
             {"SwoTapeSendInRecvPer", "in_bc_recv_per", "接带人", False}, _
             {"SwoTapeSendOutTime", "out_bc_time", "取代时间", False}, _
             {"SwoTapeSendOutSendPer", "out_bc_send_per", "发带人", False}, _
             {"SwoTapeSendOutRecvPer", "out_bc_recv_per", "取带人", False}}

    Public SwoMaterial As Object(,) = _
           {{"SwoMaterialName", "material_name", "名称", True}, _
            {"SwoMaterialLength", "length", "时长", True}, _
            {"SwoMaterialStatus", "status", "状态", True}}

    '指纹识别的数据源
    Public FingerPrintDataSource As String = "Data Source=C:\Program Files\ZKTime5.0\att2000.mdb;"

    '用来给dialog1显示的图片
    Public PictrueBmp As Bitmap = Nothing

    '存放后台线程id的list
    Public MyThreadList As ThreadList
End Module
