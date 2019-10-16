namespace Cabinets
{
    partial class fCabinets
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bCheckFirstAidKits = new System.Windows.Forms.Button();
            this.bCheckRooms = new System.Windows.Forms.Button();
            this.gbRoomDetails = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFirstAidKits = new System.Windows.Forms.DataGridView();
            this.cFAKKit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFAKName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFAKManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFAKNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRoomLamps = new System.Windows.Forms.DataGridView();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bAllLamps = new System.Windows.Forms.Button();
            this.bRussianLamps = new System.Windows.Forms.Button();
            this.dgvLamps = new System.Windows.Forms.DataGridView();
            this.cALMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbRoomDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirstAidKits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomLamps)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLamps)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиДанныеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // вывестиДанныеToolStripMenuItem
            // 
            this.вывестиДанныеToolStripMenuItem.Name = "вывестиДанныеToolStripMenuItem";
            this.вывестиДанныеToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.вывестиДанныеToolStripMenuItem.Text = "Вывести данные";
            this.вывестиДанныеToolStripMenuItem.Click += new System.EventHandler(this.вывестиДанныеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 702);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.bCheckFirstAidKits);
            this.tabPage1.Controls.Add(this.bCheckRooms);
            this.tabPage1.Controls.Add(this.gbRoomDetails);
            this.tabPage1.Controls.Add(this.cbRoom);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 676);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кабинеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(709, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Переместить лампу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Переместить аптечку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCheckFirstAidKits
            // 
            this.bCheckFirstAidKits.Location = new System.Drawing.Point(460, 17);
            this.bCheckFirstAidKits.Name = "bCheckFirstAidKits";
            this.bCheckFirstAidKits.Size = new System.Drawing.Size(137, 34);
            this.bCheckFirstAidKits.TabIndex = 6;
            this.bCheckFirstAidKits.Text = "Проверка аптечек на укомплектованность";
            this.bCheckFirstAidKits.UseVisualStyleBackColor = true;
            this.bCheckFirstAidKits.Click += new System.EventHandler(this.bCheckFirstAidKits_Click);
            // 
            // bCheckRooms
            // 
            this.bCheckRooms.Location = new System.Drawing.Point(320, 17);
            this.bCheckRooms.Name = "bCheckRooms";
            this.bCheckRooms.Size = new System.Drawing.Size(134, 34);
            this.bCheckRooms.TabIndex = 5;
            this.bCheckRooms.Text = "проверка кабинетов на наличие аптечек";
            this.bCheckRooms.UseVisualStyleBackColor = true;
            this.bCheckRooms.Click += new System.EventHandler(this.bCheckRooms_Click);
            // 
            // gbRoomDetails
            // 
            this.gbRoomDetails.Controls.Add(this.label3);
            this.gbRoomDetails.Controls.Add(this.label2);
            this.gbRoomDetails.Controls.Add(this.dgvFirstAidKits);
            this.gbRoomDetails.Controls.Add(this.dgvRoomLamps);
            this.gbRoomDetails.Location = new System.Drawing.Point(6, 52);
            this.gbRoomDetails.Name = "gbRoomDetails";
            this.gbRoomDetails.Size = new System.Drawing.Size(986, 621);
            this.gbRoomDetails.TabIndex = 4;
            this.gbRoomDetails.TabStop = false;
            this.gbRoomDetails.Text = "Данные о кабинете";
            this.gbRoomDetails.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Аптечки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Лампы";
            // 
            // dgvFirstAidKits
            // 
            this.dgvFirstAidKits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirstAidKits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFAKKit,
            this.cFAKName,
            this.cFAKManufacturer,
            this.cFAKNumber});
            this.dgvFirstAidKits.Location = new System.Drawing.Point(482, 32);
            this.dgvFirstAidKits.Name = "dgvFirstAidKits";
            this.dgvFirstAidKits.Size = new System.Drawing.Size(498, 583);
            this.dgvFirstAidKits.TabIndex = 1;
            // 
            // cFAKKit
            // 
            this.cFAKKit.HeaderText = "Аптечка";
            this.cFAKKit.Name = "cFAKKit";
            // 
            // cFAKName
            // 
            this.cFAKName.HeaderText = "Наименование медикамента";
            this.cFAKName.Name = "cFAKName";
            // 
            // cFAKManufacturer
            // 
            this.cFAKManufacturer.HeaderText = "Производитель";
            this.cFAKManufacturer.Name = "cFAKManufacturer";
            // 
            // cFAKNumber
            // 
            this.cFAKNumber.HeaderText = "Количество";
            this.cFAKNumber.Name = "cFAKNumber";
            // 
            // dgvRoomLamps
            // 
            this.dgvRoomLamps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomLamps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLMark,
            this.cLType,
            this.cLManufacturer});
            this.dgvRoomLamps.Location = new System.Drawing.Point(15, 32);
            this.dgvRoomLamps.Name = "dgvRoomLamps";
            this.dgvRoomLamps.Size = new System.Drawing.Size(446, 583);
            this.dgvRoomLamps.TabIndex = 0;
            // 
            // cbRoom
            // 
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(6, 25);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(294, 21);
            this.cbRoom.TabIndex = 3;
            this.cbRoom.SelectedValueChanged += new System.EventHandler(this.cbRoom_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кабинет";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bAllLamps);
            this.tabPage2.Controls.Add(this.bRussianLamps);
            this.tabPage2.Controls.Add(this.dgvLamps);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 676);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Лампы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bAllLamps
            // 
            this.bAllLamps.Location = new System.Drawing.Point(874, 65);
            this.bAllLamps.Name = "bAllLamps";
            this.bAllLamps.Size = new System.Drawing.Size(120, 34);
            this.bAllLamps.TabIndex = 2;
            this.bAllLamps.Text = "Все лампы";
            this.bAllLamps.UseVisualStyleBackColor = true;
            this.bAllLamps.Click += new System.EventHandler(this.bAllLamps_Click);
            // 
            // bRussianLamps
            // 
            this.bRussianLamps.Location = new System.Drawing.Point(874, 6);
            this.bRussianLamps.Name = "bRussianLamps";
            this.bRussianLamps.Size = new System.Drawing.Size(120, 53);
            this.bRussianLamps.TabIndex = 1;
            this.bRussianLamps.Text = "Лампы от отечественного производителя";
            this.bRussianLamps.UseVisualStyleBackColor = true;
            this.bRussianLamps.Click += new System.EventHandler(this.bRussianLamps_Click);
            // 
            // dgvLamps
            // 
            this.dgvLamps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLamps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cALMark,
            this.cALType,
            this.cALManufacturer,
            this.cALPrice});
            this.dgvLamps.Location = new System.Drawing.Point(-4, 0);
            this.dgvLamps.Name = "dgvLamps";
            this.dgvLamps.Size = new System.Drawing.Size(872, 669);
            this.dgvLamps.TabIndex = 0;
            // 
            // cALMark
            // 
            this.cALMark.HeaderText = "Маркировка";
            this.cALMark.Name = "cALMark";
            // 
            // cALType
            // 
            this.cALType.HeaderText = "Тип";
            this.cALType.Name = "cALType";
            // 
            // cALManufacturer
            // 
            this.cALManufacturer.HeaderText = "Производитель";
            this.cALManufacturer.Name = "cALManufacturer";
            // 
            // cALPrice
            // 
            this.cALPrice.HeaderText = "Цена";
            this.cALPrice.Name = "cALPrice";
            // 
            // cLMark
            // 
            this.cLMark.HeaderText = "Маркировка";
            this.cLMark.Name = "cLMark";
            // 
            // cLType
            // 
            this.cLType.HeaderText = "Тип";
            this.cLType.Name = "cLType";
            // 
            // cLManufacturer
            // 
            this.cLManufacturer.HeaderText = "Производитель";
            this.cLManufacturer.Name = "cLManufacturer";
            // 
            // fCabinets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fCabinets";
            this.Text = "Кабинеты";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbRoomDetails.ResumeLayout(false);
            this.gbRoomDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirstAidKits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomLamps)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLamps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bAllLamps;
        private System.Windows.Forms.Button bRussianLamps;
        private System.Windows.Forms.DataGridView dgvLamps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbRoomDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRoomLamps;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Button bCheckFirstAidKits;
        private System.Windows.Forms.Button bCheckRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALPrice;
        private System.Windows.Forms.DataGridView dgvFirstAidKits;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFAKKit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFAKName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFAKManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFAKNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLManufacturer;
    }
}

