<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        TaskTab = New TabPage()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        TaskJaage1 = New ComboBox()
        DataFill1 = New Button()
        TaskOutBut = New Button()
        TaskStarFill1 = New ComboBox()
        TaskInpTex = New TextBox()
        TaskInpBut = New Button()
        TaskIdFill1 = New ComboBox()
        TaskSetFill1 = New ComboBox()
        DataGridView1 = New DataGridView()
        TaskPropTab = New TabPage()
        Label13 = New Label()
        DataFill2 = New Button()
        TaskOutPropBut = New Button()
        Label12 = New Label()
        TaskpropTex = New TextBox()
        TaskJaage2 = New ComboBox()
        Label11 = New Label()
        DataGridView2 = New DataGridView()
        TaskInpPropBut = New Button()
        Label10 = New Label()
        TaskStarFill2 = New ComboBox()
        TaskIdFill2 = New ComboBox()
        TaskSetFill2 = New ComboBox()
        TaskScoreTab = New TabPage()
        Label17 = New Label()
        DataFill3 = New Button()
        TaskJaage3 = New ComboBox()
        DataGridView4 = New DataGridView()
        TaskIdFill3 = New ComboBox()
        Label16 = New Label()
        TaskName = New ComboBox()
        TaskStarFill3 = New ComboBox()
        TaskFinFill = New ComboBox()
        TaskSetFill3 = New ComboBox()
        Label19 = New Label()
        Label15 = New Label()
        Label18 = New Label()
        Label14 = New Label()
        BindingSource1 = New BindingSource(components)
        PomTimer = New Label()
        RealTimer = New Label()
        PomStartBut = New Button()
        PomFintBut = New Button()
        FirstPomStarTimer = New ComboBox()
        InBreakTimer = New ComboBox()
        TextBox2 = New TextBox()
        FirstTaskIdCom = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TabControl1.SuspendLayout()
        TaskTab.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TaskPropTab.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        TaskScoreTab.SuspendLayout()
        CType(DataGridView4, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TaskTab)
        TabControl1.Controls.Add(TaskPropTab)
        TabControl1.Controls.Add(TaskScoreTab)
        TabControl1.Location = New Point(332, 96)
        TabControl1.Margin = New Padding(3, 2, 3, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(440, 454)
        TabControl1.TabIndex = 0
        ' 
        ' TaskTab
        ' 
        TaskTab.AutoScroll = True
        TaskTab.BackColor = SystemColors.ActiveCaption
        TaskTab.Controls.Add(Label6)
        TaskTab.Controls.Add(Label5)
        TaskTab.Controls.Add(Label4)
        TaskTab.Controls.Add(Label3)
        TaskTab.Controls.Add(TaskJaage1)
        TaskTab.Controls.Add(DataFill1)
        TaskTab.Controls.Add(TaskOutBut)
        TaskTab.Controls.Add(TaskStarFill1)
        TaskTab.Controls.Add(TaskInpTex)
        TaskTab.Controls.Add(TaskInpBut)
        TaskTab.Controls.Add(TaskIdFill1)
        TaskTab.Controls.Add(TaskSetFill1)
        TaskTab.Controls.Add(DataGridView1)
        TaskTab.Location = New Point(4, 24)
        TaskTab.Margin = New Padding(3, 2, 3, 2)
        TaskTab.Name = "TaskTab"
        TaskTab.Padding = New Padding(3, 2, 3, 2)
        TaskTab.Size = New Size(432, 426)
        TaskTab.TabIndex = 0
        TaskTab.Text = "タスク"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(326, 83)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 16)
        Label6.TabIndex = 10
        Label6.Text = "進捗状況"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(224, 83)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 16)
        Label5.TabIndex = 10
        Label5.Text = "セット数"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(122, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 16)
        Label4.TabIndex = 10
        Label4.Text = "開始時刻"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(20, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 16)
        Label3.TabIndex = 10
        Label3.Text = "タスクID"
        ' 
        ' TaskJaage1
        ' 
        TaskJaage1.FormattingEnabled = True
        TaskJaage1.Location = New Point(326, 102)
        TaskJaage1.Name = "TaskJaage1"
        TaskJaage1.Size = New Size(83, 23)
        TaskJaage1.TabIndex = 15
        ' 
        ' DataFill1
        ' 
        DataFill1.Location = New Point(327, 19)
        DataFill1.Name = "DataFill1"
        DataFill1.Size = New Size(83, 54)
        DataFill1.TabIndex = 11
        DataFill1.Text = "検索"
        DataFill1.UseVisualStyleBackColor = True
        ' 
        ' TaskOutBut
        ' 
        TaskOutBut.Location = New Point(20, 48)
        TaskOutBut.Name = "TaskOutBut"
        TaskOutBut.Size = New Size(83, 25)
        TaskOutBut.TabIndex = 9
        TaskOutBut.Text = "完了"
        TaskOutBut.UseVisualStyleBackColor = True
        ' 
        ' TaskStarFill1
        ' 
        TaskStarFill1.FormattingEnabled = True
        TaskStarFill1.Location = New Point(122, 102)
        TaskStarFill1.Name = "TaskStarFill1"
        TaskStarFill1.Size = New Size(83, 23)
        TaskStarFill1.TabIndex = 16
        ' 
        ' TaskInpTex
        ' 
        TaskInpTex.AcceptsReturn = True
        TaskInpTex.Location = New Point(109, 19)
        TaskInpTex.Multiline = True
        TaskInpTex.Name = "TaskInpTex"
        TaskInpTex.Size = New Size(198, 54)
        TaskInpTex.TabIndex = 10
        ' 
        ' TaskInpBut
        ' 
        TaskInpBut.Location = New Point(20, 19)
        TaskInpBut.Name = "TaskInpBut"
        TaskInpBut.Size = New Size(83, 25)
        TaskInpBut.TabIndex = 8
        TaskInpBut.Text = "追加"
        TaskInpBut.UseVisualStyleBackColor = True
        ' 
        ' TaskIdFill1
        ' 
        TaskIdFill1.FormattingEnabled = True
        TaskIdFill1.Location = New Point(20, 102)
        TaskIdFill1.Name = "TaskIdFill1"
        TaskIdFill1.Size = New Size(83, 23)
        TaskIdFill1.TabIndex = 17
        ' 
        ' TaskSetFill1
        ' 
        TaskSetFill1.FormattingEnabled = True
        TaskSetFill1.Location = New Point(224, 102)
        TaskSetFill1.Name = "TaskSetFill1"
        TaskSetFill1.Size = New Size(83, 23)
        TaskSetFill1.TabIndex = 18
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Window
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(20, 130)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(390, 280)
        DataGridView1.TabIndex = 0
        ' 
        ' TaskPropTab
        ' 
        TaskPropTab.BackColor = SystemColors.GradientActiveCaption
        TaskPropTab.Controls.Add(Label13)
        TaskPropTab.Controls.Add(DataFill2)
        TaskPropTab.Controls.Add(TaskOutPropBut)
        TaskPropTab.Controls.Add(Label12)
        TaskPropTab.Controls.Add(TaskpropTex)
        TaskPropTab.Controls.Add(TaskJaage2)
        TaskPropTab.Controls.Add(Label11)
        TaskPropTab.Controls.Add(DataGridView2)
        TaskPropTab.Controls.Add(TaskInpPropBut)
        TaskPropTab.Controls.Add(Label10)
        TaskPropTab.Controls.Add(TaskStarFill2)
        TaskPropTab.Controls.Add(TaskIdFill2)
        TaskPropTab.Controls.Add(TaskSetFill2)
        TaskPropTab.Location = New Point(4, 24)
        TaskPropTab.Margin = New Padding(3, 2, 3, 2)
        TaskPropTab.Name = "TaskPropTab"
        TaskPropTab.Padding = New Padding(3, 2, 3, 2)
        TaskPropTab.Size = New Size(432, 426)
        TaskPropTab.TabIndex = 1
        TaskPropTab.Text = "タスク詳細"
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label13.Location = New Point(326, 83)
        Label13.Name = "Label13"
        Label13.Size = New Size(62, 16)
        Label13.TabIndex = 10
        Label13.Text = "進捗状況"
        ' 
        ' DataFill2
        ' 
        DataFill2.Location = New Point(326, 19)
        DataFill2.Name = "DataFill2"
        DataFill2.Size = New Size(83, 54)
        DataFill2.TabIndex = 19
        DataFill2.Text = "検索"
        DataFill2.UseVisualStyleBackColor = True
        ' 
        ' TaskOutPropBut
        ' 
        TaskOutPropBut.Location = New Point(20, 48)
        TaskOutPropBut.Name = "TaskOutPropBut"
        TaskOutPropBut.Size = New Size(83, 25)
        TaskOutPropBut.TabIndex = 14
        TaskOutPropBut.Text = "削除"
        TaskOutPropBut.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label12.Location = New Point(224, 83)
        Label12.Name = "Label12"
        Label12.Size = New Size(62, 16)
        Label12.TabIndex = 10
        Label12.Text = "セット数"
        ' 
        ' TaskpropTex
        ' 
        TaskpropTex.AcceptsReturn = True
        TaskpropTex.Location = New Point(109, 21)
        TaskpropTex.Multiline = True
        TaskpropTex.Name = "TaskpropTex"
        TaskpropTex.Size = New Size(198, 54)
        TaskpropTex.TabIndex = 13
        ' 
        ' TaskJaage2
        ' 
        TaskJaage2.FormattingEnabled = True
        TaskJaage2.Location = New Point(326, 102)
        TaskJaage2.Name = "TaskJaage2"
        TaskJaage2.Size = New Size(83, 23)
        TaskJaage2.TabIndex = 9
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(122, 83)
        Label11.Name = "Label11"
        Label11.Size = New Size(62, 16)
        Label11.TabIndex = 10
        Label11.Text = "開始時刻"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = SystemColors.Window
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(20, 130)
        DataGridView2.Margin = New Padding(3, 2, 3, 2)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(390, 280)
        DataGridView2.TabIndex = 11
        ' 
        ' TaskInpPropBut
        ' 
        TaskInpPropBut.Location = New Point(20, 19)
        TaskInpPropBut.Name = "TaskInpPropBut"
        TaskInpPropBut.Size = New Size(83, 25)
        TaskInpPropBut.TabIndex = 11
        TaskInpPropBut.Text = "追加"
        TaskInpPropBut.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label10.Location = New Point(20, 83)
        Label10.Name = "Label10"
        Label10.Size = New Size(65, 16)
        Label10.TabIndex = 10
        Label10.Text = "タスクID"
        ' 
        ' TaskStarFill2
        ' 
        TaskStarFill2.FormattingEnabled = True
        TaskStarFill2.Location = New Point(122, 102)
        TaskStarFill2.Name = "TaskStarFill2"
        TaskStarFill2.Size = New Size(83, 23)
        TaskStarFill2.TabIndex = 9
        ' 
        ' TaskIdFill2
        ' 
        TaskIdFill2.FormattingEnabled = True
        TaskIdFill2.Location = New Point(20, 102)
        TaskIdFill2.Name = "TaskIdFill2"
        TaskIdFill2.Size = New Size(83, 23)
        TaskIdFill2.TabIndex = 9
        ' 
        ' TaskSetFill2
        ' 
        TaskSetFill2.FormattingEnabled = True
        TaskSetFill2.Location = New Point(224, 102)
        TaskSetFill2.Name = "TaskSetFill2"
        TaskSetFill2.Size = New Size(83, 23)
        TaskSetFill2.TabIndex = 9
        ' 
        ' TaskScoreTab
        ' 
        TaskScoreTab.BackColor = Color.DarkSeaGreen
        TaskScoreTab.Controls.Add(Label17)
        TaskScoreTab.Controls.Add(DataFill3)
        TaskScoreTab.Controls.Add(TaskJaage3)
        TaskScoreTab.Controls.Add(DataGridView4)
        TaskScoreTab.Controls.Add(TaskIdFill3)
        TaskScoreTab.Controls.Add(Label16)
        TaskScoreTab.Controls.Add(TaskName)
        TaskScoreTab.Controls.Add(TaskStarFill3)
        TaskScoreTab.Controls.Add(TaskFinFill)
        TaskScoreTab.Controls.Add(TaskSetFill3)
        TaskScoreTab.Controls.Add(Label19)
        TaskScoreTab.Controls.Add(Label15)
        TaskScoreTab.Controls.Add(Label18)
        TaskScoreTab.Controls.Add(Label14)
        TaskScoreTab.Location = New Point(4, 24)
        TaskScoreTab.Name = "TaskScoreTab"
        TaskScoreTab.Size = New Size(432, 426)
        TaskScoreTab.TabIndex = 2
        TaskScoreTab.Text = "タスク一覧"
        ' 
        ' Label17
        ' 
        Label17.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label17.Location = New Point(326, 83)
        Label17.Name = "Label17"
        Label17.Size = New Size(62, 16)
        Label17.TabIndex = 10
        Label17.Text = "進捗状況"
        ' 
        ' DataFill3
        ' 
        DataFill3.Location = New Point(326, 22)
        DataFill3.Name = "DataFill3"
        DataFill3.Size = New Size(83, 45)
        DataFill3.TabIndex = 20
        DataFill3.Text = "検索"
        DataFill3.UseVisualStyleBackColor = True
        ' 
        ' TaskJaage3
        ' 
        TaskJaage3.FormattingEnabled = True
        TaskJaage3.Location = New Point(326, 102)
        TaskJaage3.Name = "TaskJaage3"
        TaskJaage3.Size = New Size(83, 23)
        TaskJaage3.TabIndex = 20
        ' 
        ' DataGridView4
        ' 
        DataGridView4.BackgroundColor = SystemColors.Window
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView4.Location = New Point(20, 130)
        DataGridView4.Margin = New Padding(3, 2, 3, 2)
        DataGridView4.Name = "DataGridView4"
        DataGridView4.RowHeadersWidth = 51
        DataGridView4.Size = New Size(390, 280)
        DataGridView4.TabIndex = 14
        ' 
        ' TaskIdFill3
        ' 
        TaskIdFill3.FormattingEnabled = True
        TaskIdFill3.Location = New Point(20, 44)
        TaskIdFill3.Name = "TaskIdFill3"
        TaskIdFill3.Size = New Size(83, 23)
        TaskIdFill3.TabIndex = 22
        ' 
        ' Label16
        ' 
        Label16.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label16.Location = New Point(224, 83)
        Label16.Name = "Label16"
        Label16.Size = New Size(62, 16)
        Label16.TabIndex = 10
        Label16.Text = "セット数"
        ' 
        ' TaskName
        ' 
        TaskName.FormattingEnabled = True
        TaskName.Location = New Point(122, 44)
        TaskName.Name = "TaskName"
        TaskName.Size = New Size(185, 23)
        TaskName.TabIndex = 21
        ' 
        ' TaskStarFill3
        ' 
        TaskStarFill3.FormattingEnabled = True
        TaskStarFill3.Location = New Point(20, 102)
        TaskStarFill3.Name = "TaskStarFill3"
        TaskStarFill3.Size = New Size(83, 23)
        TaskStarFill3.TabIndex = 22
        ' 
        ' TaskFinFill
        ' 
        TaskFinFill.FormattingEnabled = True
        TaskFinFill.Location = New Point(122, 102)
        TaskFinFill.Name = "TaskFinFill"
        TaskFinFill.Size = New Size(83, 23)
        TaskFinFill.TabIndex = 21
        ' 
        ' TaskSetFill3
        ' 
        TaskSetFill3.FormattingEnabled = True
        TaskSetFill3.Location = New Point(224, 102)
        TaskSetFill3.Name = "TaskSetFill3"
        TaskSetFill3.Size = New Size(83, 23)
        TaskSetFill3.TabIndex = 23
        ' 
        ' Label19
        ' 
        Label19.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label19.Location = New Point(122, 25)
        Label19.Name = "Label19"
        Label19.Size = New Size(62, 16)
        Label19.TabIndex = 10
        Label19.Text = "タスク"
        ' 
        ' Label15
        ' 
        Label15.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label15.Location = New Point(122, 83)
        Label15.Name = "Label15"
        Label15.Size = New Size(62, 16)
        Label15.TabIndex = 10
        Label15.Text = "終了時刻"
        ' 
        ' Label18
        ' 
        Label18.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label18.Location = New Point(20, 25)
        Label18.Name = "Label18"
        Label18.Size = New Size(65, 16)
        Label18.TabIndex = 10
        Label18.Text = "タスクID"
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("メイリオ", 9.75F, FontStyle.Bold)
        Label14.Location = New Point(20, 83)
        Label14.Name = "Label14"
        Label14.Size = New Size(65, 16)
        Label14.TabIndex = 10
        Label14.Text = "開始時刻"
        ' 
        ' PomTimer
        ' 
        PomTimer.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        PomTimer.Font = New Font("Microsoft Sans Serif", 50.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PomTimer.ForeColor = Color.Red
        PomTimer.Location = New Point(26, 168)
        PomTimer.Name = "PomTimer"
        PomTimer.Size = New Size(250, 100)
        PomTimer.TabIndex = 1
        PomTimer.Text = "mm:ss"
        PomTimer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RealTimer
        ' 
        RealTimer.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        RealTimer.Font = New Font("メイリオ", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        RealTimer.ForeColor = SystemColors.ActiveCaptionText
        RealTimer.Location = New Point(340, 31)
        RealTimer.Name = "RealTimer"
        RealTimer.Size = New Size(432, 50)
        RealTimer.TabIndex = 3
        RealTimer.Text = "yyyy/MM/dd hh:mm"
        RealTimer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PomStartBut
        ' 
        PomStartBut.Location = New Point(45, 472)
        PomStartBut.Name = "PomStartBut"
        PomStartBut.Size = New Size(91, 38)
        PomStartBut.TabIndex = 4
        PomStartBut.Text = "開始"
        PomStartBut.UseVisualStyleBackColor = True
        ' 
        ' PomFintBut
        ' 
        PomFintBut.Location = New Point(171, 472)
        PomFintBut.Name = "PomFintBut"
        PomFintBut.Size = New Size(91, 38)
        PomFintBut.TabIndex = 5
        PomFintBut.Text = "終了"
        PomFintBut.UseVisualStyleBackColor = True
        ' 
        ' FirstPomStarTimer
        ' 
        FirstPomStarTimer.FormattingEnabled = True
        FirstPomStarTimer.Items.AddRange(New Object() {"25分", "30分"})
        FirstPomStarTimer.Location = New Point(171, 360)
        FirstPomStarTimer.Name = "FirstPomStarTimer"
        FirstPomStarTimer.Size = New Size(121, 23)
        FirstPomStarTimer.TabIndex = 6
        ' 
        ' InBreakTimer
        ' 
        InBreakTimer.FormattingEnabled = True
        InBreakTimer.Items.AddRange(New Object() {"15", "20", "25"})
        InBreakTimer.Location = New Point(171, 403)
        InBreakTimer.Name = "InBreakTimer"
        InBreakTimer.Size = New Size(121, 23)
        InBreakTimer.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.Font = New Font("メイリオ", 39.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        TextBox2.ForeColor = Color.Black
        TextBox2.Location = New Point(26, 31)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(266, 87)
        TextBox2.TabIndex = 8
        TextBox2.Text = "トマト君" & vbCrLf
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' FirstTaskIdCom
        ' 
        FirstTaskIdCom.FormattingEnabled = True
        FirstTaskIdCom.Location = New Point(171, 315)
        FirstTaskIdCom.Name = "FirstTaskIdCom"
        FirstTaskIdCom.Size = New Size(121, 23)
        FirstTaskIdCom.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("メイリオ", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label7.Location = New Point(42, 403)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 25)
        Label7.TabIndex = 10
        Label7.Text = "休憩時間"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("メイリオ", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label8.Location = New Point(42, 360)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 25)
        Label8.TabIndex = 10
        Label8.Text = "タスク時間"
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("メイリオ", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label9.Location = New Point(42, 315)
        Label9.Name = "Label9"
        Label9.Size = New Size(94, 25)
        Label9.TabIndex = 10
        Label9.Text = "タスクID"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 561)
        Controls.Add(FirstTaskIdCom)
        Controls.Add(TextBox2)
        Controls.Add(InBreakTimer)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(FirstPomStarTimer)
        Controls.Add(PomFintBut)
        Controls.Add(PomStartBut)
        Controls.Add(RealTimer)
        Controls.Add(PomTimer)
        Controls.Add(TabControl1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TaskTab.ResumeLayout(False)
        TaskTab.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TaskPropTab.ResumeLayout(False)
        TaskPropTab.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        TaskScoreTab.ResumeLayout(False)
        CType(DataGridView4, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TaskTab As TabPage
    Friend WithEvents TaskPropTab As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PomTimer As Label
    Friend WithEvents RealTimer As Label
    Friend WithEvents PomStartBut As Button
    Friend WithEvents PomFintBut As Button
    Friend WithEvents FirstPomStarTimer As ComboBox
    Friend WithEvents InBreakTimer As ComboBox
    Friend WithEvents TaskInpTex As TextBox
    Friend WithEvents TaskInpBut As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TaskScoreTab As TabPage
    Friend WithEvents TaskpropTex As TextBox
    Friend WithEvents TaskInpPropBut As Button
    Friend WithEvents TaskIdFill2 As ComboBox
    Friend WithEvents TaskStarFill2 As ComboBox
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents TaskOutBut As Button
    Friend WithEvents TaskOutPropBut As Button
    Friend WithEvents TaskJaage2 As ComboBox
    Friend WithEvents TaskSetFill2 As ComboBox
    Friend WithEvents TaskJaage1 As ComboBox
    Friend WithEvents DataFill1 As Button
    Friend WithEvents TaskStarFill1 As ComboBox
    Friend WithEvents TaskIdFill1 As ComboBox
    Friend WithEvents TaskSetFill1 As ComboBox
    Friend WithEvents DataFill2 As Button
    Friend WithEvents TaskJaage3 As ComboBox
    Friend WithEvents TaskIdFill3 As ComboBox
    Friend WithEvents TaskName As ComboBox
    Friend WithEvents TaskStarFill3 As ComboBox
    Friend WithEvents TaskFinFill As ComboBox
    Friend WithEvents TaskSetFill3 As ComboBox
    Friend WithEvents DataFill3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents FirstTaskIdCom As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label

End Class
