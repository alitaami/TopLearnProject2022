﻿SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [UserName], [Email], [Password], [AcctiveCode], [IsActive], [UserAvatar], [RegistersDate], [IsDelete]) VALUES (1, N'alitaami', N'alitaamicr7@gmail.com', N'20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70', N'1c51332885af41d7b35a5887f559e33c', 1, N'c9c72f1b650747e98c827d63bb2bf9f4.jpg', CAST(N'2022-10-02T13:58:27.0154220' AS DateTime2), 0)
INSERT [dbo].[Users] ([UserId], [UserName], [Email], [Password], [AcctiveCode], [IsActive], [UserAvatar], [RegistersDate], [IsDelete]) VALUES (2, N'efi', N'efi85@gmail.com', N'20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70', N'3dce6c24553b40b981b4c44637fb2997', 1, N'defaultavatar.jpg', CAST(N'2022-10-26T11:59:53.8632348' AS DateTime2), 0)
INSERT [dbo].[Users] ([UserId], [UserName], [Email], [Password], [AcctiveCode], [IsActive], [UserAvatar], [RegistersDate], [IsDelete]) VALUES (3, N'asdasd', N'a@gmail.com', N'20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70', N'29601e00b7e3444fa1e578d5debd9c11', 1, NULL, CAST(N'2022-12-04T00:31:10.8025831' AS DateTime2), 1)
INSERT [dbo].[Users] ([UserId], [UserName], [Email], [Password], [AcctiveCode], [IsActive], [UserAvatar], [RegistersDate], [IsDelete]) VALUES (12, N'admin', N'admin@gmail.com', N'21-23-2F-29-7A-57-A5-A7-43-89-4A-0E-4A-80-1F-C3', N'68ab895fdb0141de82be14d38da4e5fa', 1, N'defaultavatar.jpg', CAST(N'2024-01-25T01:18:36.5018621' AS DateTime2), 0)
INSERT [dbo].[Users] ([UserId], [UserName], [Email], [Password], [AcctiveCode], [IsActive], [UserAvatar], [RegistersDate], [IsDelete]) VALUES (13, N'mahdi', N'mahdisedgi@gmail.com', N'20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70', N'7a9e89da295c4a74bee2f9ea3e64f9fc', 1, N'defaultavatar.jpg', CAST(N'2024-01-25T01:20:27.9670327' AS DateTime2), 0)
INSERT [dbo].[Users] ([UserId], [UserName], [Email], [Password], [AcctiveCode], [IsActive], [UserAvatar], [RegistersDate], [IsDelete]) VALUES (16, N'husen', N'Hosseinzares.work@gmail.com', N'20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70', N'be8c6d239cef4fb1ab958e1ccd417dc8', 1, N'defaultavatar.jpg', CAST(N'2024-01-25T13:01:41.0095632' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [UserId], [OrderSum], [IsFinaly], [CreateDate]) VALUES (1010, 1, 100000, 1, CAST(N'2022-11-14T10:25:47.0186868' AS DateTime2))
INSERT [dbo].[Orders] ([OrderId], [UserId], [OrderSum], [IsFinaly], [CreateDate]) VALUES (1011, 1, 21000, 1, CAST(N'2022-11-25T01:34:07.5476406' AS DateTime2))
INSERT [dbo].[Orders] ([OrderId], [UserId], [OrderSum], [IsFinaly], [CreateDate]) VALUES (1012, 1, 200000, 1, CAST(N'2022-11-25T13:51:42.7360066' AS DateTime2))
INSERT [dbo].[Orders] ([OrderId], [UserId], [OrderSum], [IsFinaly], [CreateDate]) VALUES (1013, 1, 30000, 1, CAST(N'2022-11-28T02:25:36.2467285' AS DateTime2))
INSERT [dbo].[Orders] ([OrderId], [UserId], [OrderSum], [IsFinaly], [CreateDate]) VALUES (1014, 1, 430000, 1, CAST(N'2023-01-04T10:45:12.4933146' AS DateTime2))
INSERT [dbo].[Orders] ([OrderId], [UserId], [OrderSum], [IsFinaly], [CreateDate]) VALUES (1019, 16, 100000, 1, CAST(N'2024-01-25T13:03:30.1222076' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[CourseGroup] ON 

INSERT [dbo].[CourseGroup] ([GroupId], [GroupTitle], [IsDelete], [ParentId]) VALUES (1, N'برنامه نویسی وب', 0, NULL)
INSERT [dbo].[CourseGroup] ([GroupId], [GroupTitle], [IsDelete], [ParentId]) VALUES (2, N'برنامه نویسی  asp.net core', 0, 1)
INSERT [dbo].[CourseGroup] ([GroupId], [GroupTitle], [IsDelete], [ParentId]) VALUES (3, N'برنامه نویسی php', 0, 1)
INSERT [dbo].[CourseGroup] ([GroupId], [GroupTitle], [IsDelete], [ParentId]) VALUES (4, N'برنامه نویسی ویندوز', 0, NULL)
INSERT [dbo].[CourseGroup] ([GroupId], [GroupTitle], [IsDelete], [ParentId]) VALUES (5, N'سی شارپ', 0, 4)
INSERT [dbo].[CourseGroup] ([GroupId], [GroupTitle], [IsDelete], [ParentId]) VALUES (6, N'پایتون', 0, 4)
INSERT [dbo].[CourseGroup] ([GroupId], [GroupTitle], [IsDelete], [ParentId]) VALUES (16, N'طراحی وب سایت', 0, NULL)
INSERT [dbo].[CourseGroup] ([GroupId], [GroupTitle], [IsDelete], [ParentId]) VALUES (17, N'جاوااسکریپت', 0, 16)
INSERT [dbo].[CourseGroup] ([GroupId], [GroupTitle], [IsDelete], [ParentId]) VALUES (18, N'ری اکت', 0, 16)
INSERT [dbo].[CourseGroup] ([GroupId], [GroupTitle], [IsDelete], [ParentId]) VALUES (19, N'جانگو', 0, 16)
INSERT [dbo].[CourseGroup] ([GroupId], [GroupTitle], [IsDelete], [ParentId]) VALUES (20, N'وردپرس', 0, NULL)
INSERT [dbo].[CourseGroup] ([GroupId], [GroupTitle], [IsDelete], [ParentId]) VALUES (21, N'وردپرس', 0, 20)
SET IDENTITY_INSERT [dbo].[CourseGroup] OFF
GO
SET IDENTITY_INSERT [dbo].[CourseLevels] ON 

INSERT [dbo].[CourseLevels] ([LevelId], [LevelTitle]) VALUES (1, N'مقدماتی')
INSERT [dbo].[CourseLevels] ([LevelId], [LevelTitle]) VALUES (2, N'متوسط')
INSERT [dbo].[CourseLevels] ([LevelId], [LevelTitle]) VALUES (3, N'پیشرفته')
SET IDENTITY_INSERT [dbo].[CourseLevels] OFF
GO
SET IDENTITY_INSERT [dbo].[CourseStatuses] ON 

INSERT [dbo].[CourseStatuses] ([StatusId], [StatusTitle]) VALUES (1, N'در حال برگزاری')
INSERT [dbo].[CourseStatuses] ([StatusId], [StatusTitle]) VALUES (2, N'به پایان رسیده')
SET IDENTITY_INSERT [dbo].[CourseStatuses] OFF
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([CourseId], [GroupId], [SubGroup], [TeacherId], [StatusId], [LevelId], [CourseTitle], [CourseDescription], [CoursePrice], [Tags], [CourseImageName], [DemoFileName], [CreateDate], [UpdateDate]) VALUES (1, 1, 2, 1, 1, 1, N'دوره برنامه نویسی core', N'<p>&nbsp;</p>

<p>دوره پروژه محور net core.&nbsp;</p>
', 30000, N'core', N'b0bbde93e1a444f697a276fb0dbf26ab.jpg', N'59f92608c3fe4ee2aed6a70c814d09f7.jpg', CAST(N'2022-10-04T13:48:35.9860000' AS DateTime2), CAST(N'2022-10-07T13:27:06.2685870' AS DateTime2))
INSERT [dbo].[Courses] ([CourseId], [GroupId], [SubGroup], [TeacherId], [StatusId], [LevelId], [CourseTitle], [CourseDescription], [CoursePrice], [Tags], [CourseImageName], [DemoFileName], [CreateDate], [UpdateDate]) VALUES (2, 1, 3, 1, 2, 2, N'دوره php', N'<p>دوره بسیار پیشرفته</p>
', 30000, N'php', N'8c8325ec328844e5b6181ab3acb95945.jpg', N'31e74f8c22234a5bb088d9297e27654e.jpg', CAST(N'2022-10-08T12:43:51.3750000' AS DateTime2), CAST(N'2022-10-08T12:45:20.4738858' AS DateTime2))
INSERT [dbo].[Courses] ([CourseId], [GroupId], [SubGroup], [TeacherId], [StatusId], [LevelId], [CourseTitle], [CourseDescription], [CoursePrice], [Tags], [CourseImageName], [DemoFileName], [CreateDate], [UpdateDate]) VALUES (3, 1, 2, 1, 2, 1, N'asp.net متوسط', N'<p>--</p>
', 100000, N'asp', N'60aa65ad4a134f7bbb6e07863d17c5f2.jpg', N'334fe362b9f44a1b8ada22a697a3f5ef.jpg', CAST(N'2022-10-25T22:27:17.6480000' AS DateTime2), CAST(N'2022-11-25T01:51:03.8608587' AS DateTime2))
INSERT [dbo].[Courses] ([CourseId], [GroupId], [SubGroup], [TeacherId], [StatusId], [LevelId], [CourseTitle], [CourseDescription], [CoursePrice], [Tags], [CourseImageName], [DemoFileName], [CreateDate], [UpdateDate]) VALUES (8, 16, 17, 1, 1, 2, N'جاوااسکریپت', N'<p>جاوا اسکریپت یکی از مهم&zwnj;ترین زبان&zwnj;های برنامه&zwnj;نویسی حوزه&zwnj;ی وب محسوب می&zwnj;شود. جاوا اسکریپت اولین بار با اسم LiveScript و توسط شرکت نت اسکیپ معرفی شد و بعدها به جاوا اسکریپت تغییر نام داد. البته جالب است بدانید جاوا اسکریپت نه از نظر ساختار و نه از نظر مفاهیم، شباهتی به زبان جاوا ندارد و این تشابه اسمی، در حد همان کلمات و نام و نشان باقی مانده است.&nbsp;</p>

<p>&nbsp;به&zwnj;طور طبیعی بعد از یادگیری HTML و CSS نوبت یادگیری جاوا اسکریپت می&zwnj;رسد. یادگیری جاوا اسکریپت چندان کار سختی نیست؛ ولی نکته مهم در رابطه با یادگیری این زبان، آن است که بر خلاف اچ&zwnj;تی&zwnj;ام&zwnj;ال یا سی&zwnj;اس&zwnj;اس که زبان&zwnj;های نشانه&zwnj;گذاری محسوب می&zwnj;شوند، جاوا اسکریپت یک زبان &laquo;برنامه نویسی&raquo; است. پس انتظار یادگیری سریع و بدون دردسر نداشته باشید و خود را برای چالش&zwnj;های جدید و درگیری&zwnj;های ذهنی بیشتر آماده کنید.</p>

<p>&nbsp;</p>
', 100000, N'web', N'5e9f8318f5864082b6eb7f0b4cb315f3.jpg', N'97166aeac9af4e268922d897eaaa0237.jpg', CAST(N'2022-11-25T13:37:40.6710000' AS DateTime2), CAST(N'2022-11-25T13:41:32.5491347' AS DateTime2))
INSERT [dbo].[Courses] ([CourseId], [GroupId], [SubGroup], [TeacherId], [StatusId], [LevelId], [CourseTitle], [CourseDescription], [CoursePrice], [Tags], [CourseImageName], [DemoFileName], [CreateDate], [UpdateDate]) VALUES (12, 1, 19, 13, 2, 2, N'دوره حرفه ای جنگو', N'<p>اگر از عاشقان پایتون باشید, نباید از فریم ورک محبوب و البته قدرتمند جنگو غافل شوید. این فریم ورک مبتنی بر وب و سطح بالا, رایگان و البته Open Source است. &nbsp; &nbsp;</p>

<p>این فریم ورک شامل &nbsp;مجموعه ای از ماژول هاست که به شما این امکان را می دهند که برنامه یا وب سایت خود را از ابتدا طراحی نمایید.</p>

<p>شرکت های بزرگی مانند Udemy ، Pinterest ، YouTube ، Instagram &nbsp; از جمله شرکت هایی هستند که از این فریم ورک و مزایایی همچون امنیت بالا بهره مند شده اند. &nbsp;</p>
', 100000, N'django python', N'911fd57de26048d59fd180fbd9c4fbe5.jpg', N'98623d4cfdcd4e95aa7c11ec3b21f7cd.webp', CAST(N'2024-01-25T01:52:52.7530000' AS DateTime2), CAST(N'2024-01-25T02:06:25.2429723' AS DateTime2))
INSERT [dbo].[Courses] ([CourseId], [GroupId], [SubGroup], [TeacherId], [StatusId], [LevelId], [CourseTitle], [CourseDescription], [CoursePrice], [Tags], [CourseImageName], [DemoFileName], [CreateDate], [UpdateDate]) VALUES (13, 1, 6, 13, 2, 1, N'آموزش جامع Django Celery', N'<p>یک ابزار قدرتمند برای اجرای عملیات همزمان و همینطور تسک های زمان&zwnj;بندی شده در پروژه&zwnj;های Django &nbsp;می باشد. این ابزار از طریق استفاده از مفهوم صف (Queue) اجرای عملیات&zwnj;های غیرهمزمان را مدیریت می&zwnj;کند.</p>

<p>با استفاده از &nbsp;Django Celery، امکان انجام عملیات&zwnj;هایی که زمان زیادی برای اجرا نیاز دارند، به صورت غیرهمزمان فراهم می شود. به عنوان مثال، اگر در پروژه نیاز داشته باشید تا تعداد بسیار زیادی ایمیل برای کاربران خود ارسال کنید، می&zwnj;توانید این عملیات را با استفاده از این ابزار انجام دهید. در واقع ارسال ایمیل&zwnj;ها به صورت غیرهمزمان و در پس&zwnj;زمینه انجام می&zwnj;شود و کاربران می&zwnj;توانند به طور همزمان با ارسال ایمیل&zwnj;ها، به سایر بخش&zwnj;های پروژه دسترسی داشته باشند و تداخلی در انجام تسک ها ایجاد نمی شود.</p>

<p>همچنین با استفاده از &nbsp;Celeryمی&zwnj;توانید عملیات&zwnj;های زمان&zwnj;بندی شده را مدیریت کنید. به عنوان مثال، می&zwnj;توانید تعدادی تسک را برنامه&zwnj;ریزی کنید که به صورت دوره&zwnj;ای و در زمان&zwnj;های مشخص اجرا شوند. این قابلیت به شما امکان می&zwnj;دهد تا عملیات&zwnj;های مرتبط با پردازش داده&zwnj;ها، به&zwnj;روزرسانی اطلاعات و سایر وظایف مشابه را به صورت خودکار و در زمان&zwnj;های مشخص انجام دهید.</p>

<p>به طور کلی، Django Celery &nbsp;یک ابزار قدرتمند است که به شما امکان می&zwnj;دهد عملیات&zwnj;های غیرهمزمان و زمان&zwnj;بندی شده را در پروژه&zwnj;های Django مدیریت کنید. با استفاده از این ابزار، می&zwnj;توانید عملکرد و کارایی پروژه خود را بهبود داده و تجربه ی کاری بسیار خوبی را برای کاربران سایت خود فراهم کنید.</p>

<p><strong>&nbsp;</strong></p>

<p>&nbsp;</p>
', 125000, N'django python celery', N'4172babfdef64324904a5ddd1d22939d.jpg', N'f96add45aeb44a3bbee1460266479740.png', CAST(N'2024-01-25T02:05:14.0340000' AS DateTime2), CAST(N'2024-01-25T02:05:46.2966893' AS DateTime2))
INSERT [dbo].[Courses] ([CourseId], [GroupId], [SubGroup], [TeacherId], [StatusId], [LevelId], [CourseTitle], [CourseDescription], [CoursePrice], [Tags], [CourseImageName], [DemoFileName], [CreateDate], [UpdateDate]) VALUES (14, 20, 21, 13, 2, 2, N'آموزش وردپرس', N'<p>وردپرس یکی از محبوب ترین سیستم های مدیریت محتوا (CMS) در دنیا به حساب می آید. با استفاده از وردپرس می توان حتی بدون داشتن برنامه نویسی، سایت هایی با تمام امکانات و قابلیت ها ایجاد و از آن استفاده کرد. از آنجا که وردپرس یک سیستم Open Source است، به راحتی می توان با برنامه نویسی و تغییر کدها، قالب ها و امکانات جدیدی بر روی آن پیاده سازی کرد. وردپرس از سال 2003 به صورت رایگان منتشر و برای دانلود در اختیار کاربران قرار گرفت. این سیستم بر پایه PHP بوده و برنامه نویس هایی که با این زبان آشنا هستند می توانند به راحتی قابلیت ها و امکانات مورد نظرشان را پیاده سازی کنند. با این حال، در این دوره سعی بر این بوده که سایتی را بدون دانش کدنویسی راه اندازی و مدیریت کنیم. بنابراین کاربرانی که دانش برنامه نویسی نیز ندارند، می توانند پس از دوره آموزش وردپرس مقدماتی، سایتی با تمام امکانات راه اندازی کنند. در این دوره تمام اقداماتی که برای راه اندازی و مدیریت یک سایت مورد نیاز است گفته خواهد شد.</p>

<p>&nbsp;</p>

<p>(( این دوره به اتمام رسیده است&nbsp;))</p>

<p>&nbsp;</p>
', 40000, N'wordpress', N'e6bbe560504344f89be9ff9a2f5fb623.jpg', N'744a897d08cd4dd69fbf80f9bdcd967d.png', CAST(N'2024-01-25T14:00:09.4080000' AS DateTime2), CAST(N'2024-01-25T14:01:29.9802376' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([DetailId], [OrderId], [CourseId], [Price], [Count]) VALUES (1012, 1010, 3, 100000, 1)
INSERT [dbo].[OrderDetails] ([DetailId], [OrderId], [CourseId], [Price], [Count]) VALUES (1013, 1011, 2, 30000, 1)
INSERT [dbo].[OrderDetails] ([DetailId], [OrderId], [CourseId], [Price], [Count]) VALUES (1014, 1012, 8, 100000, 2)
INSERT [dbo].[OrderDetails] ([DetailId], [OrderId], [CourseId], [Price], [Count]) VALUES (1015, 1013, 1, 30000, 1)
INSERT [dbo].[OrderDetails] ([DetailId], [OrderId], [CourseId], [Price], [Count]) VALUES (1018, 1014, 1, 30000, 1)
INSERT [dbo].[OrderDetails] ([DetailId], [OrderId], [CourseId], [Price], [Count]) VALUES (1036, 1019, 8, 100000, 1)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Discounts] ON 

INSERT [dbo].[Discounts] ([DiscountId], [Percent], [UsableCount], [StartDate], [EndDate], [DiscountCode], [IsDelete]) VALUES (1, 30, 2, NULL, NULL, N'123', 1)
INSERT [dbo].[Discounts] ([DiscountId], [Percent], [UsableCount], [StartDate], [EndDate], [DiscountCode], [IsDelete]) VALUES (3, 11, 11, CAST(N'1401-01-01T00:00:00.0000000' AS DateTime2), CAST(N'1401-02-01T00:00:00.0000000' AS DateTime2), N'as21', 1)
INSERT [dbo].[Discounts] ([DiscountId], [Percent], [UsableCount], [StartDate], [EndDate], [DiscountCode], [IsDelete]) VALUES (4, 22, 20, CAST(N'1401-07-12T00:00:00.0000000' AS DateTime2), CAST(N'1401-08-12T00:00:00.0000000' AS DateTime2), N'as22', 0)
INSERT [dbo].[Discounts] ([DiscountId], [Percent], [UsableCount], [StartDate], [EndDate], [DiscountCode], [IsDelete]) VALUES (5, 22, 12, CAST(N'1401-08-19T00:00:00.0000000' AS DateTime2), CAST(N'1402-03-02T00:00:00.0000000' AS DateTime2), N'aa', 0)
INSERT [dbo].[Discounts] ([DiscountId], [Percent], [UsableCount], [StartDate], [EndDate], [DiscountCode], [IsDelete]) VALUES (10, 85, 10, CAST(N'1401-08-04T00:00:00.0000000' AS DateTime2), CAST(N'1402-05-06T00:00:00.0000000' AS DateTime2), N'elyferi', 1)
INSERT [dbo].[Discounts] ([DiscountId], [Percent], [UsableCount], [StartDate], [EndDate], [DiscountCode], [IsDelete]) VALUES (11, 25, 9, CAST(N'1401-10-14T00:00:00.0000000' AS DateTime2), CAST(N'1401-10-30T00:00:00.0000000' AS DateTime2), N'2023', 1)
SET IDENTITY_INSERT [dbo].[Discounts] OFF
GO
SET IDENTITY_INSERT [dbo].[permission] ON 

INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (1, N'پنل مدیریت', NULL)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (2, N'مدیریت کاربران', 1)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (3, N'افزودن کاربر', 2)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (4, N'ویرایش کاربر', 2)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (5, N'حذف کاربر', 2)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (6, N'مدیریت نقش ها', 1)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (7, N'افزودن نقش ', 2)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (8, N'ویرایش نقش', 2)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (9, N'حذف نقش', 2)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (10, N'مدیریت دوره ها', NULL)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (11, N'افزودن دوره', 10)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (12, N'ویرایش دوره', 10)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (13, N'افزودن جلسات', 10)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (14, N'ویرایش جلسات', 10)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (15, N'مدیریت جلسات', 10)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (16, N'مدیریت گروه ها', NULL)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (17, N'افزودن گروه ها', 16)
INSERT [dbo].[permission] ([PermissionId], [PermissionTitle], [ParentID]) VALUES (18, N'ویرایش گروه ها', 16)
SET IDENTITY_INSERT [dbo].[permission] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleId], [RoleTitle], [IsDelete]) VALUES (1, N'مدیرسایت', 0)
INSERT [dbo].[Roles] ([RoleId], [RoleTitle], [IsDelete]) VALUES (2, N'ادمین', 0)
INSERT [dbo].[Roles] ([RoleId], [RoleTitle], [IsDelete]) VALUES (3, N'کاربرعادی', 0)
INSERT [dbo].[Roles] ([RoleId], [RoleTitle], [IsDelete]) VALUES (4, N'استاد', 0)
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[RolePermission] ON 

INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (19, 2, 1)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (20, 2, 2)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (21, 2, 3)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (22, 2, 4)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (23, 2, 5)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (24, 2, 7)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (25, 2, 8)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (26, 2, 9)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (27, 2, 6)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (55, 4, 18)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (56, 4, 16)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (57, 4, 15)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (58, 4, 14)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (59, 4, 13)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (60, 4, 12)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (61, 4, 11)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (62, 4, 10)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (63, 4, 17)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (64, 4, 1)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (65, 1, 17)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (66, 1, 16)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (67, 1, 6)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (68, 1, 9)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (69, 1, 8)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (70, 1, 7)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (71, 1, 5)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (72, 1, 4)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (73, 1, 3)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (74, 1, 2)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (75, 1, 18)
INSERT [dbo].[RolePermission] ([RP_Id], [RoleId], [PermissionId]) VALUES (76, 1, 1)
SET IDENTITY_INSERT [dbo].[RolePermission] OFF
GO
SET IDENTITY_INSERT [dbo].[UserRoles] ON 

INSERT [dbo].[UserRoles] ([UR_Id], [UserID], [RoleID]) VALUES (12, 3, 1)
INSERT [dbo].[UserRoles] ([UR_Id], [UserID], [RoleID]) VALUES (15, 1, 1)
INSERT [dbo].[UserRoles] ([UR_Id], [UserID], [RoleID]) VALUES (16, 1, 2)
INSERT [dbo].[UserRoles] ([UR_Id], [UserID], [RoleID]) VALUES (17, 2, 3)
INSERT [dbo].[UserRoles] ([UR_Id], [UserID], [RoleID]) VALUES (19, 12, 2)
INSERT [dbo].[UserRoles] ([UR_Id], [UserID], [RoleID]) VALUES (20, 13, 4)
INSERT [dbo].[UserRoles] ([UR_Id], [UserID], [RoleID]) VALUES (21, 16, 3)
SET IDENTITY_INSERT [dbo].[UserRoles] OFF
GO
INSERT [dbo].[WalletTypes] ([TypeId], [TypeTitle]) VALUES (1, N'واریز')
INSERT [dbo].[WalletTypes] ([TypeId], [TypeTitle]) VALUES (2, N'برداشت')
GO
SET IDENTITY_INSERT [dbo].[Wallets] ON 

INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (2, 1, 1, 10000, N'شارژ حساب', 1, CAST(N'2022-10-04T11:17:21.7909613' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (3, 2, 1, 2000, N'شارژ حساب', 1, CAST(N'2022-10-04T11:18:26.6688593' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (4, 1, 1, 12000, N'شارژ حساب', 1, CAST(N'2022-10-04T11:23:20.9579582' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (5, 1, 1, 2000, N'شارژ حساب', 1, CAST(N'2022-10-04T11:28:00.4180773' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (6, 1, 1, 2000, N'شارژ حساب', 0, CAST(N'2022-10-04T11:30:09.0641748' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (7, 1, 1, 2000, N'شارژ حساب', 1, CAST(N'2022-10-04T11:31:07.0039369' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (8, 1, 1, 10000, N'شارژ حساب', 1, CAST(N'2022-10-04T11:33:09.1888060' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (9, 1, 1, 10000, N'شارژ حساب', 1, CAST(N'2022-10-04T11:35:14.3383495' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (10, 1, 1, 200000, N'شارژ حساب', 0, CAST(N'2022-10-12T11:00:25.2919425' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (19, 1, 1, 20000000, N'شارژ حساب', 1, CAST(N'2022-10-12T11:00:25.2919425' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (20, 1, 1, 100000, N'شارژ حساب', 0, CAST(N'2022-10-12T13:18:19.1739709' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (21, 2, 1, 300000, N'فاکتور شماره #3', 1, CAST(N'2022-10-14T12:38:18.1460194' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (22, 2, 1, 30000, N'فاکتور شماره #4', 1, CAST(N'2022-10-14T12:41:31.1080160' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (23, 2, 1, 30000, N'فاکتور شماره #5', 1, CAST(N'2022-10-14T12:48:09.1598171' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (24, 2, 1, 30000, N'فاکتور شماره #6', 1, CAST(N'2022-10-14T12:49:29.0915186' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (25, 2, 1, 30000, N'فاکتور شماره #7', 1, CAST(N'2022-10-14T12:53:58.2329167' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (26, 2, 1, 30000, N'فاکتور شماره #8', 1, CAST(N'2022-10-14T12:55:22.0913828' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (27, 2, 1, 30000, N'فاکتور شماره #9', 1, CAST(N'2022-10-14T12:58:26.1427712' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (28, 2, 1, 30000, N'فاکتور شماره #10', 1, CAST(N'2022-10-14T13:00:18.3660055' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1010, 2, 1, 450000, N'فاکتور شماره #11', 1, CAST(N'2022-10-21T11:02:19.5521829' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1011, 2, 1, 21000, N'فاکتور شماره #1002', 1, CAST(N'2022-10-21T11:05:58.0513809' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1012, 2, 1, 60000, N'فاکتور شماره #1003', 1, CAST(N'2022-10-21T11:10:58.5897012' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1013, 2, 1, 30000, N'فاکتور شماره #1004', 1, CAST(N'2022-10-21T11:14:37.7690972' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1014, 2, 1, 30000, N'فاکتور شماره #1005', 1, CAST(N'2022-10-21T11:17:15.8226567' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1015, 2, 1, 60000, N'فاکتور شماره #1006', 1, CAST(N'2022-10-21T11:43:05.8413851' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1016, 2, 1, 163800, N'فاکتور شماره #1007', 1, CAST(N'2022-10-22T00:29:34.8224405' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1017, 2, 1, 45000, N'فاکتور شماره #1008', 1, CAST(N'2022-10-26T10:29:42.1176229' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1018, 2, 1, 100000, N'فاکتور شماره #1009', 1, CAST(N'2022-10-26T11:02:32.8348776' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1019, 2, 1, 100000, N'فاکتور شماره #1010', 1, CAST(N'2022-11-14T10:25:52.0037359' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1020, 2, 1, 21000, N'فاکتور شماره #1011', 1, CAST(N'2022-11-25T01:34:34.3913305' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1021, 2, 1, 200000, N'فاکتور شماره #1012', 1, CAST(N'2022-11-27T12:59:36.4213351' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1022, 1, 1, 10000000, N'شارژ حساب', 1, CAST(N'2022-11-27T12:59:56.9329900' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1023, 2, 1, 30000, N'فاکتور شماره #1013', 1, CAST(N'2022-11-28T02:25:50.1360236' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1024, 1, 1, 100000, N'شارژ حساب', 0, CAST(N'2022-12-14T16:35:08.0406300' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1025, 1, 1, 1000, N'شارژ حساب', 0, CAST(N'2022-12-14T16:35:24.8466307' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1026, 1, 1, 100000, N'شارژ حساب', 0, CAST(N'2022-12-19T13:26:14.5535108' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1027, 1, 1, 100000, N'شارژ حساب', 0, CAST(N'2022-12-21T20:36:43.7099596' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1028, 1, 1, 6666, N'شارژ حساب', 1, CAST(N'2023-10-10T18:49:20.4509678' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1029, 2, 1, 430000, N'فاکتور شماره #1014', 1, CAST(N'2023-10-10T19:10:34.0188042' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1030, 1, 1, 190000, N'شارژ حساب', 1, CAST(N'2023-10-19T21:12:01.2759137' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1031, 1, 1, 2222, N'شارژ حساب', 1, CAST(N'2023-11-18T23:05:59.1254507' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1032, 1, 1, 222222, N'شارژ حساب', 1, CAST(N'2023-11-18T23:12:53.4533111' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1033, 1, 1, 88888, N'شارژ حساب', 1, CAST(N'2023-11-19T20:27:33.8353579' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1034, 1, 1, 10000, N'شارژ حساب', 1, CAST(N'2023-11-30T16:03:57.1788371' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1040, 1, 16, 1000001, N'شارژ حساب', 1, CAST(N'2024-01-25T13:03:37.6695768' AS DateTime2))
INSERT [dbo].[Wallets] ([WalletId], [TypeId], [UserId], [Amount], [Description], [IsPay], [CreateDate]) VALUES (1041, 2, 16, 100000, N'فاکتور شماره #1019', 1, CAST(N'2024-01-25T13:04:06.5934772' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Wallets] OFF
GO
SET IDENTITY_INSERT [dbo].[UserCourses] ON 

INSERT [dbo].[UserCourses] ([UC_Id], [UserId], [CourseId]) VALUES (1013, 1, 3)
INSERT [dbo].[UserCourses] ([UC_Id], [UserId], [CourseId]) VALUES (1014, 1, 2)
INSERT [dbo].[UserCourses] ([UC_Id], [UserId], [CourseId]) VALUES (1017, 1, 1)
INSERT [dbo].[UserCourses] ([UC_Id], [UserId], [CourseId]) VALUES (1020, 16, 8)
SET IDENTITY_INSERT [dbo].[UserCourses] OFF
GO
SET IDENTITY_INSERT [dbo].[CourseComments] ON 

INSERT [dbo].[CourseComments] ([CommentId], [CourseId], [UserId], [Comment], [CreateDate], [IsDelete], [IsAdminRead]) VALUES (106, 1, 1, N'سلام و عرض ادب', CAST(N'2022-11-02T19:08:59.7936701' AS DateTime2), 0, 0)
INSERT [dbo].[CourseComments] ([CommentId], [CourseId], [UserId], [Comment], [CreateDate], [IsDelete], [IsAdminRead]) VALUES (168, 1, 1, N'قسمت اخر رو قرار بدید', CAST(N'2022-11-04T11:34:35.5947724' AS DateTime2), 0, 0)
INSERT [dbo].[CourseComments] ([CommentId], [CourseId], [UserId], [Comment], [CreateDate], [IsDelete], [IsAdminRead]) VALUES (169, 3, 1, N'بسیار دوره خوبی بود', CAST(N'2022-11-04T11:39:52.9642838' AS DateTime2), 0, 0)
INSERT [dbo].[CourseComments] ([CommentId], [CourseId], [UserId], [Comment], [CreateDate], [IsDelete], [IsAdminRead]) VALUES (221, 3, 1, N'عالی بود', CAST(N'2023-11-30T15:29:35.2339811' AS DateTime2), 0, 0)
INSERT [dbo].[CourseComments] ([CommentId], [CourseId], [UserId], [Comment], [CreateDate], [IsDelete], [IsAdminRead]) VALUES (222, 3, 1, N'زیبا بود', CAST(N'2023-11-30T15:34:12.6892656' AS DateTime2), 0, 0)
INSERT [dbo].[CourseComments] ([CommentId], [CourseId], [UserId], [Comment], [CreateDate], [IsDelete], [IsAdminRead]) VALUES (223, 3, 1, N'مدرس خیلی مسلط بود', CAST(N'2023-11-30T15:37:48.2989171' AS DateTime2), 0, 0)
INSERT [dbo].[CourseComments] ([CommentId], [CourseId], [UserId], [Comment], [CreateDate], [IsDelete], [IsAdminRead]) VALUES (224, 3, 1, N'as', CAST(N'2023-12-12T19:52:49.0939089' AS DateTime2), 0, 0)
INSERT [dbo].[CourseComments] ([CommentId], [CourseId], [UserId], [Comment], [CreateDate], [IsDelete], [IsAdminRead]) VALUES (225, 3, 1, N'asd', CAST(N'2023-12-12T19:53:03.9157907' AS DateTime2), 0, 0)
INSERT [dbo].[CourseComments] ([CommentId], [CourseId], [UserId], [Comment], [CreateDate], [IsDelete], [IsAdminRead]) VALUES (227, 8, 16, N'عالی بود', CAST(N'2024-01-25T13:04:25.3223637' AS DateTime2), 0, 0)
SET IDENTITY_INSERT [dbo].[CourseComments] OFF
GO
SET IDENTITY_INSERT [dbo].[CourseEpisodes] ON 

INSERT [dbo].[CourseEpisodes] ([EpisodeId], [CourseId], [EpisodeTitle], [EpisodeTime], [EpisodeFileName], [IsFree]) VALUES (1, 1, N'قسمت 1', CAST(N'00:11:00' AS Time), N'2ea3c579-b590-4179-bb53-d78084d3e1caaspcore.jpg', 0)
INSERT [dbo].[CourseEpisodes] ([EpisodeId], [CourseId], [EpisodeTitle], [EpisodeTime], [EpisodeFileName], [IsFree]) VALUES (2, 1, N'قسمت 2', CAST(N'00:34:00' AS Time), N'0828c49f-ee26-4541-b374-0b1a965e387013d5a74e-4641-4922-9eb5-adc271285c7creactjs.png', 0)
INSERT [dbo].[CourseEpisodes] ([EpisodeId], [CourseId], [EpisodeTitle], [EpisodeTime], [EpisodeFileName], [IsFree]) VALUES (3, 1, N'شیشسیشس', CAST(N'00:20:00' AS Time), N'IMG-20210122-WA0032.jpg', 1)
INSERT [dbo].[CourseEpisodes] ([EpisodeId], [CourseId], [EpisodeTitle], [EpisodeTime], [EpisodeFileName], [IsFree]) VALUES (4, 12, N'جلسه اول (آشنایی با جنگو)', CAST(N'00:10:00' AS Time), N'assadasda.png', 1)
INSERT [dbo].[CourseEpisodes] ([EpisodeId], [CourseId], [EpisodeTitle], [EpisodeTime], [EpisodeFileName], [IsFree]) VALUES (5, 12, N'جلسه دوم (شروع کار با جنگو)', CAST(N'00:32:00' AS Time), N'Animation - 1705097824928.mp4', 0)
INSERT [dbo].[CourseEpisodes] ([EpisodeId], [CourseId], [EpisodeTitle], [EpisodeTime], [EpisodeFileName], [IsFree]) VALUES (6, 13, N'جلسه اول (آشنایی)', CAST(N'00:05:12' AS Time), N'آموزش_جامع_django_celery.jpg', 1)
INSERT [dbo].[CourseEpisodes] ([EpisodeId], [CourseId], [EpisodeTitle], [EpisodeTime], [EpisodeFileName], [IsFree]) VALUES (7, 14, N'جلسه اول', CAST(N'00:20:20' AS Time), N'دوره_آموزش_WordPress.jpg', 1)
INSERT [dbo].[CourseEpisodes] ([EpisodeId], [CourseId], [EpisodeTitle], [EpisodeTime], [EpisodeFileName], [IsFree]) VALUES (8, 14, N'جلسه دوم', CAST(N'00:10:00' AS Time), N'89a0be500ee8464185bc66960135cc7b.jpg', 0)
INSERT [dbo].[CourseEpisodes] ([EpisodeId], [CourseId], [EpisodeTitle], [EpisodeTime], [EpisodeFileName], [IsFree]) VALUES (9, 14, N'جلسه سوم', CAST(N'00:50:00' AS Time), N'New Text Document.txt', 0)
INSERT [dbo].[CourseEpisodes] ([EpisodeId], [CourseId], [EpisodeTitle], [EpisodeTime], [EpisodeFileName], [IsFree]) VALUES (10, 14, N'جلسه چهارم (پایانی)', CAST(N'01:20:00' AS Time), N'صفحات_و_فیچرهای_پنل_های_ادمین_و_فروشنده.pdf', 0)
SET IDENTITY_INSERT [dbo].[CourseEpisodes] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220705084003_m1', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220705084716_m12', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220721090203_232d', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220808072612_sd', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220815084412_ndas', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220827101313_ada', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220903090316_coursemig', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220904102307_dsdaswm', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220917193531_sda11', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221002091717_mff', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221002093150_mffk', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221002093529_mffklk', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221002094110_mffklkk2', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221002101205_mffk0', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221005081231_dd', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221007185743_orders', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221007203310_orders', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221014085230_usercourse', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221018074421_discount', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221018074940_discount1', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221021070843_ud-mig', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221022094511_mig-up', N'3.1.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221027172058_comments', N'3.1.0')
GO
