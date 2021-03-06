USE [nntv_ps]
GO
/****** 对象:  Table [dbo].[checkup]    脚本日期: 11/26/2014 09:27:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[checkup](
	[tape_name] [varchar](100) NOT NULL,
	[check_type] [varchar](20) NULL,
	[length] [varchar](20) NULL,
	[date_or_episode_check] [bit] NULL,
	[episode_screenshot] [image] NULL,
	[sound_picture_sync] [bit] NULL,
	[volume_check] [bit] NULL,
	[check_point1_timecode] [varchar](20) NULL,
	[check_point2_timecode] [varchar](20) NULL,
	[check_point3_timecode] [varchar](20) NULL,
	[check_point1_screenshot] [image] NULL,
	[check_point2_screenshot] [image] NULL,
	[check_point3_screenshot] [image] NULL,
	[check_status] [int] NULL,
	[remark] [varchar](200) NULL,
	[check_person] [varchar](50) NULL,
	[check_time] [datetime] NULL,
	[material_id] [uniqueidentifier] NULL,
	[checkup_id] [uniqueidentifier] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** 对象:  Table [dbo].[tape_status]    脚本日期: 11/26/2014 09:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tape_status](
	[status] [varchar](20) NOT NULL,
	[code] [int] NOT NULL,
	[tape_status] [varchar](50) NULL,
	[material_status] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** 对象:  Table [dbo].[person]    脚本日期: 11/26/2014 09:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[person](
	[name] [varchar](50) NOT NULL,
	[telephone] [varchar](50) NULL,
	[department] [varchar](50) NULL,
	[id] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** 对象:  Table [dbo].[fix_timecode]    脚本日期: 11/26/2014 09:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fix_timecode](
	[tape_id] [uniqueidentifier] NULL,
	[tape_name] [varchar](50) NULL,
	[new_start_timecode] [varchar](50) NULL,
	[new_length] [varchar](50) NULL,
	[old_start_timecode] [varchar](50) NULL,
	[old_length] [varchar](50) NULL,
	[fix_time] [varchar](50) NULL,
	[fix_person] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** 对象:  Table [dbo].[accessmanage]    脚本日期: 11/26/2014 09:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[accessmanage](
	[person_id] [varchar](50) NULL,
	[person_name] [varchar](50) NULL,
	[inbc_send] [bit] NULL,
	[inbc_recv] [bit] NULL,
	[outbc_send] [bit] NULL,
	[outbc_recv] [bit] NULL,
	[upload] [bit] NULL,
	[checkup] [bit] NULL,
	[edit] [bit] NULL,
	[admin] [bit] NULL,
	[password] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** 对象:  Table [dbo].[tape]    脚本日期: 11/26/2014 09:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tape](
	[tape_name] [varchar](100) NOT NULL,
	[in_bc_time] [datetime] NULL,
	[out_bc_time] [datetime] NULL,
	[in_bc_send_per] [varchar](50) NULL,
	[in_bc_recv_per] [varchar](50) NULL,
	[out_bc_send_per] [varchar](50) NULL,
	[out_bc_recv_per] [varchar](50) NULL,
	[start_timecode] [varchar](20) NOT NULL CONSTRAINT [DF_tape_start_timecode]  DEFAULT (''),
	[end_timecode] [varchar](20) NOT NULL CONSTRAINT [DF_tape_end_timecode]  DEFAULT (''),
	[length] [varchar](20) NOT NULL CONSTRAINT [DF_tape_length]  DEFAULT (''),
	[identical] [bit] NULL,
	[episode_check] [bit] NULL,
	[remark] [varchar](200) NULL,
	[tape_status] [int] NULL,
	[channel] [varchar](50) NULL,
	[id] [uniqueidentifier] NULL,
	[program_type] [varchar](50) NULL,
	[department] [varchar](50) NULL,
	[in_bc_send_per_id] [varchar](50) NULL,
	[media_type] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** 对象:  Table [dbo].[material]    脚本日期: 11/26/2014 09:27:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[material](
	[material_name] [varchar](50) NOT NULL,
	[id] [uniqueidentifier] NOT NULL,
	[tape_id] [uniqueidentifier] NOT NULL,
	[start_timecode] [varchar](20) NULL,
	[end_timecode] [varchar](20) NULL,
	[length] [varchar](20) NULL,
	[status] [int] NULL,
	[material_len] [varchar](20) NULL,
	[fake] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** 对象:  Table [dbo].[upload]    脚本日期: 11/26/2014 09:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[upload](
	[tape_name] [varchar](100) NOT NULL,
	[upload_time] [datetime] NULL,
	[start_timecode] [varchar](20) NULL,
	[end_timecode] [varchar](20) NULL,
	[length] [varchar](20) NULL,
	[volume_check] [bit] NULL,
	[image_check] [bit] NULL,
	[episode_check] [bit] NULL,
	[screenshot] [image] NULL,
	[remark] [varchar](200) NULL,
	[upload_per] [varchar](50) NULL,
	[upload_status] [int] NULL,
	[upload_type] [varchar](20) NULL,
	[material_id] [uniqueidentifier] NULL,
	[tape_id] [uniqueidentifier] NULL,
	[upload_channel] [varchar](20) NULL,
	[upload_pc] [varchar](50) NULL,
	[camera] [image] NULL,
	[fake] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** 对象:  Table [dbo].[longset]    脚本日期: 11/26/2014 09:27:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[longset](
	[blong] [float] NULL,
	[mlong] [float] NULL,
	[elong] [float] NULL
) ON [PRIMARY]
GO
