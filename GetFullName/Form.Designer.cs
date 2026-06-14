namespace GetFullName
{
    partial class GetFullname
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
            this.btnGetFullname = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGetFullname
            // 
            this.btnGetFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetFullname.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetFullname.Location = new System.Drawing.Point(194, 52);
            this.btnGetFullname.Name = "btnGetFullname";
            this.btnGetFullname.Size = new System.Drawing.Size(170, 43);
            this.btnGetFullname.TabIndex = 0;
            this.btnGetFullname.Text = "Получить из API";
            this.btnGetFullname.UseVisualStyleBackColor = true;
            this.btnGetFullname.Click += new System.EventHandler(this.btnGetFullname_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО:";
            // 
            // tbFullname
            // 
            this.tbFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFullname.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFullname.Location = new System.Drawing.Point(84, 12);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.ReadOnly = true;
            this.tbFullname.Size = new System.Drawing.Size(280, 34);
            this.tbFullname.TabIndex = 3;
            // 
            // rtbMessage
            // 
            this.rtbMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbMessage.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMessage.Location = new System.Drawing.Point(18, 99);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(346, 78);
            this.rtbMessage.TabIndex = 4;
            this.rtbMessage.Text = "";
            // 
            // GetFullname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 189);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.tbFullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetFullname);
            this.MinimumSize = new System.Drawing.Size(395, 228);
            this.Name = "GetFullname";
            this.Text = "Получение ФИО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetFullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.RichTextBox rtbMessage;
    }
}

