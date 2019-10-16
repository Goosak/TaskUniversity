namespace Cabinets
{
    partial class Transport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lChoose = new System.Windows.Forms.Label();
            this.cbChoose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNewRoom = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lChoose
            // 
            this.lChoose.AutoSize = true;
            this.lChoose.Location = new System.Drawing.Point(12, 9);
            this.lChoose.Name = "lChoose";
            this.lChoose.Size = new System.Drawing.Size(35, 13);
            this.lChoose.TabIndex = 0;
            this.lChoose.Text = "label1";
            // 
            // cbChoose
            // 
            this.cbChoose.FormattingEnabled = true;
            this.cbChoose.Location = new System.Drawing.Point(12, 25);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(222, 21);
            this.cbChoose.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кабинет:";
            // 
            // cbNewRoom
            // 
            this.cbNewRoom.FormattingEnabled = true;
            this.cbNewRoom.Location = new System.Drawing.Point(12, 65);
            this.cbNewRoom.Name = "cbNewRoom";
            this.cbNewRoom.Size = new System.Drawing.Size(222, 21);
            this.cbNewRoom.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Переместить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbNewRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChoose);
            this.Controls.Add(this.lChoose);
            this.Name = "Transport";
            this.Text = "Transport";
            this.Load += new System.EventHandler(this.Transport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lChoose;
        private System.Windows.Forms.ComboBox cbChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNewRoom;
        private System.Windows.Forms.Button button1;
    }
}