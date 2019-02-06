namespace XZPaint
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PenColor = new System.Windows.Forms.Button();
            this.btn_CanvasColor = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioFill = new System.Windows.Forms.RadioButton();
            this.radioFillCir = new System.Windows.Forms.RadioButton();
            this.radioFilRect = new System.Windows.Forms.RadioButton();
            this.cmb_PenSize = new System.Windows.Forms.ComboBox();
            this.radioElipse = new System.Windows.Forms.RadioButton();
            this.radioRect = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.radioBrush = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSharpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aquarelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bluurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radioEraser = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 417);
            this.panel2.TabIndex = 10;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 386);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(105, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_PenColor);
            this.panel3.Controls.Add(this.btn_CanvasColor);
            this.panel3.Location = new System.Drawing.Point(12, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 123);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Color";
            // 
            // btn_PenColor
            // 
            this.btn_PenColor.BackColor = System.Drawing.Color.Black;
            this.btn_PenColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_PenColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PenColor.Location = new System.Drawing.Point(15, 30);
            this.btn_PenColor.Name = "btn_PenColor";
            this.btn_PenColor.Size = new System.Drawing.Size(53, 51);
            this.btn_PenColor.TabIndex = 4;
            this.btn_PenColor.UseVisualStyleBackColor = false;
            this.btn_PenColor.Click += new System.EventHandler(this.btn_PenColor_Click);
            // 
            // btn_CanvasColor
            // 
            this.btn_CanvasColor.BackColor = System.Drawing.Color.White;
            this.btn_CanvasColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CanvasColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CanvasColor.Location = new System.Drawing.Point(33, 50);
            this.btn_CanvasColor.Name = "btn_CanvasColor";
            this.btn_CanvasColor.Size = new System.Drawing.Size(56, 57);
            this.btn_CanvasColor.TabIndex = 5;
            this.btn_CanvasColor.UseVisualStyleBackColor = false;
            this.btn_CanvasColor.Click += new System.EventHandler(this.btn_CanvasColor_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Menu;
            this.panel4.Controls.Add(this.radioEraser);
            this.panel4.Controls.Add(this.radioFill);
            this.panel4.Controls.Add(this.radioFillCir);
            this.panel4.Controls.Add(this.radioFilRect);
            this.panel4.Controls.Add(this.cmb_PenSize);
            this.panel4.Controls.Add(this.radioElipse);
            this.panel4.Controls.Add(this.radioRect);
            this.panel4.Controls.Add(this.radioLine);
            this.panel4.Controls.Add(this.radioBrush);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(105, 239);
            this.panel4.TabIndex = 0;
            // 
            // radioFill
            // 
            this.radioFill.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioFill.BackgroundImage")));
            this.radioFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioFill.Location = new System.Drawing.Point(9, 141);
            this.radioFill.Name = "radioFill";
            this.radioFill.Size = new System.Drawing.Size(39, 39);
            this.radioFill.TabIndex = 10;
            this.radioFill.TabStop = true;
            this.radioFill.UseVisualStyleBackColor = true;
            // 
            // radioFillCir
            // 
            this.radioFillCir.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFillCir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioFillCir.BackgroundImage")));
            this.radioFillCir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioFillCir.Location = new System.Drawing.Point(54, 96);
            this.radioFillCir.Name = "radioFillCir";
            this.radioFillCir.Size = new System.Drawing.Size(39, 39);
            this.radioFillCir.TabIndex = 9;
            this.radioFillCir.TabStop = true;
            this.radioFillCir.UseVisualStyleBackColor = true;
            // 
            // radioFilRect
            // 
            this.radioFilRect.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFilRect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioFilRect.BackgroundImage")));
            this.radioFilRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioFilRect.Location = new System.Drawing.Point(54, 51);
            this.radioFilRect.Name = "radioFilRect";
            this.radioFilRect.Size = new System.Drawing.Size(39, 39);
            this.radioFilRect.TabIndex = 8;
            this.radioFilRect.TabStop = true;
            this.radioFilRect.UseVisualStyleBackColor = true;
            // 
            // cmb_PenSize
            // 
            this.cmb_PenSize.FormattingEnabled = true;
            this.cmb_PenSize.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmb_PenSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_PenSize.Location = new System.Drawing.Point(15, 204);
            this.cmb_PenSize.MaxLength = 2;
            this.cmb_PenSize.Name = "cmb_PenSize";
            this.cmb_PenSize.Size = new System.Drawing.Size(74, 21);
            this.cmb_PenSize.TabIndex = 1;
            this.cmb_PenSize.SelectedIndexChanged += new System.EventHandler(this.cmb_PenSize_SelectedIndexChanged);
            // 
            // radioElipse
            // 
            this.radioElipse.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioElipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioElipse.BackgroundImage")));
            this.radioElipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioElipse.Location = new System.Drawing.Point(9, 96);
            this.radioElipse.Name = "radioElipse";
            this.radioElipse.Size = new System.Drawing.Size(39, 39);
            this.radioElipse.TabIndex = 7;
            this.radioElipse.UseVisualStyleBackColor = true;
            // 
            // radioRect
            // 
            this.radioRect.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioRect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioRect.BackgroundImage")));
            this.radioRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioRect.Location = new System.Drawing.Point(9, 51);
            this.radioRect.Name = "radioRect";
            this.radioRect.Size = new System.Drawing.Size(39, 39);
            this.radioRect.TabIndex = 6;
            this.radioRect.UseVisualStyleBackColor = true;
            // 
            // radioLine
            // 
            this.radioLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioLine.BackgroundImage")));
            this.radioLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioLine.Location = new System.Drawing.Point(54, 6);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(39, 39);
            this.radioLine.TabIndex = 5;
            this.radioLine.UseVisualStyleBackColor = true;
            // 
            // radioBrush
            // 
            this.radioBrush.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBrush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioBrush.BackgroundImage")));
            this.radioBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioBrush.Checked = true;
            this.radioBrush.Location = new System.Drawing.Point(9, 6);
            this.radioBrush.Name = "radioBrush";
            this.radioBrush.Size = new System.Drawing.Size(39, 39);
            this.radioBrush.TabIndex = 4;
            this.radioBrush.TabStop = true;
            this.radioBrush.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(167, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 421);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 414);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.transformToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.rotate90ToolStripMenuItem,
            this.mirrorXToolStripMenuItem,
            this.mirrorYToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            this.sizeToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // rotate90ToolStripMenuItem
            // 
            this.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            this.rotate90ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.rotate90ToolStripMenuItem.Text = "Rotate 90°";
            this.rotate90ToolStripMenuItem.Click += new System.EventHandler(this.rotate90ToolStripMenuItem_Click);
            // 
            // mirrorXToolStripMenuItem
            // 
            this.mirrorXToolStripMenuItem.Name = "mirrorXToolStripMenuItem";
            this.mirrorXToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mirrorXToolStripMenuItem.Text = "Mirror X";
            this.mirrorXToolStripMenuItem.Click += new System.EventHandler(this.mirrorXToolStripMenuItem_Click);
            // 
            // mirrorYToolStripMenuItem
            // 
            this.mirrorYToolStripMenuItem.Name = "mirrorYToolStripMenuItem";
            this.mirrorYToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mirrorYToolStripMenuItem.Text = "Mirror Y";
            this.mirrorYToolStripMenuItem.Click += new System.EventHandler(this.mirrorYToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightnessContrastToolStripMenuItem,
            this.colorBalanceToolStripMenuItem,
            this.colorSharpeningToolStripMenuItem,
            this.aquarelleToolStripMenuItem,
            this.stampingToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.bluurToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // brightnessContrastToolStripMenuItem
            // 
            this.brightnessContrastToolStripMenuItem.Name = "brightnessContrastToolStripMenuItem";
            this.brightnessContrastToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.brightnessContrastToolStripMenuItem.Text = "Brightness/Contrast";
            this.brightnessContrastToolStripMenuItem.Click += new System.EventHandler(this.brightnessContrastToolStripMenuItem_Click);
            // 
            // colorBalanceToolStripMenuItem
            // 
            this.colorBalanceToolStripMenuItem.Name = "colorBalanceToolStripMenuItem";
            this.colorBalanceToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.colorBalanceToolStripMenuItem.Text = "Color balance";
            this.colorBalanceToolStripMenuItem.Click += new System.EventHandler(this.colorBalanceToolStripMenuItem_Click);
            // 
            // colorSharpeningToolStripMenuItem
            // 
            this.colorSharpeningToolStripMenuItem.Name = "colorSharpeningToolStripMenuItem";
            this.colorSharpeningToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.colorSharpeningToolStripMenuItem.Text = "Color sharpening";
            this.colorSharpeningToolStripMenuItem.Click += new System.EventHandler(this.colorSharpeningToolStripMenuItem_Click);
            // 
            // aquarelleToolStripMenuItem
            // 
            this.aquarelleToolStripMenuItem.Name = "aquarelleToolStripMenuItem";
            this.aquarelleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aquarelleToolStripMenuItem.Text = "Aquarelle";
            this.aquarelleToolStripMenuItem.Click += new System.EventHandler(this.aquarelleToolStripMenuItem_Click);
            // 
            // stampingToolStripMenuItem
            // 
            this.stampingToolStripMenuItem.Name = "stampingToolStripMenuItem";
            this.stampingToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.stampingToolStripMenuItem.Text = "Stamping";
            this.stampingToolStripMenuItem.Click += new System.EventHandler(this.stampingToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // bluurToolStripMenuItem
            // 
            this.bluurToolStripMenuItem.Name = "bluurToolStripMenuItem";
            this.bluurToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.bluurToolStripMenuItem.Text = "Bluur";
            this.bluurToolStripMenuItem.Click += new System.EventHandler(this.bluurToolStripMenuItem_Click);
            // 
            // transformToolStripMenuItem
            // 
            this.transformToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.scaleToolStripMenuItem,
            this.mirrorToolStripMenuItem});
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.transformToolStripMenuItem.Text = "Transform";
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.moveToolStripMenuItem.Text = "move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.rotateToolStripMenuItem.Text = "rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.scaleToolStripMenuItem.Text = "scale";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
            // 
            // mirrorToolStripMenuItem
            // 
            this.mirrorToolStripMenuItem.Name = "mirrorToolStripMenuItem";
            this.mirrorToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.mirrorToolStripMenuItem.Text = "mirror";
            this.mirrorToolStripMenuItem.Click += new System.EventHandler(this.mirrorToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radioEraser
            // 
            this.radioEraser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioEraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioEraser.BackgroundImage")));
            this.radioEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioEraser.Location = new System.Drawing.Point(54, 141);
            this.radioEraser.Name = "radioEraser";
            this.radioEraser.Size = new System.Drawing.Size(39, 39);
            this.radioEraser.TabIndex = 11;
            this.radioEraser.TabStop = true;
            this.radioEraser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(923, 502);
            this.Name = "Form1";
            this.Text = "XZPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_CanvasColor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_PenColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioElipse;
        private System.Windows.Forms.RadioButton radioRect;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.RadioButton radioBrush;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_PenSize;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorSharpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bluurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioFilRect;
        private System.Windows.Forms.RadioButton radioFillCir;
        private System.Windows.Forms.RadioButton radioFill;
        private System.Windows.Forms.ToolStripMenuItem transformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stampingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aquarelleToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioEraser;
    }
}

