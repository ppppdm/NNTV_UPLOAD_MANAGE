Module Var_public
    Public xuhao As Integer '用来表征项目的序号


    Public user1 As String
    Public flag As Integer '用来表征是操作的第几步p 

    Public cutpicsrc As Integer '用来表征和截屏幕截图是否按下
    Public pid As Integer '用来表征节目的序号，唯一标识
    Public cutcount As Integer '用来表征截图按钮是否被按下，按下为1，没按下为0
    Public cutcountsrc As Integer '用来表征屏幕截图按钮是否被按下，按下为1，没按下为0
    Public updown As Integer  '用来表征点击“下一步”是第一次走还是通过点击“上一步”再点击的“下一步”，前者为0，后者为1
    Public picflag As Integer '用来表征数据库中是否已有截图，如果有则为1，没有则为0.当其为1时，在点击“下一步”时，不用截图
    Public lookflag = 1  '用来表征回看项目到哪一步了，默认为1，在第一步
    Public pname_public As String '公共的用于存放节目名称的变量

    Public connstr1 = "Provider=SQLOLEDB;Server=127.0.0.1;Database=nntv_ps;User ID=sa;Password=nntv@2014;"
End Module
