namespace AjandekLista
{
    partial class Form1
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
            this.ajandekLstBx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nevTB = new System.Windows.Forms.TextBox();
            this.uzletTB = new System.Windows.Forms.TextBox();
            this.nevLbl = new System.Windows.Forms.Label();
            this.uzletLbl = new System.Windows.Forms.Label();
            this.mentesBtn = new System.Windows.Forms.Button();
            this.torlesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ajandekLstBx
            // 
            this.ajandekLstBx.FormattingEnabled = true;
            this.ajandekLstBx.Location = new System.Drawing.Point(8, 6);
            this.ajandekLstBx.Name = "ajandekLstBx";
            this.ajandekLstBx.Size = new System.Drawing.Size(353, 173);
            this.ajandekLstBx.TabIndex = 0;
            this.ajandekLstBx.SelectedIndexChanged += new System.EventHandler(this.ajandekLstBx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(79, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Új ajándék hozzáadása:";
            // 
            // nevTB
            // 
            this.nevTB.Location = new System.Drawing.Point(75, 311);
            this.nevTB.Name = "nevTB";
            this.nevTB.Size = new System.Drawing.Size(201, 20);
            this.nevTB.TabIndex = 2;
            // 
            // uzletTB
            // 
            this.uzletTB.Location = new System.Drawing.Point(75, 360);
            this.uzletTB.Name = "uzletTB";
            this.uzletTB.Size = new System.Drawing.Size(201, 20);
            this.uzletTB.TabIndex = 3;
            // 
            // nevLbl
            // 
            this.nevLbl.AutoSize = true;
            this.nevLbl.Location = new System.Drawing.Point(75, 295);
            this.nevLbl.Name = "nevLbl";
            this.nevLbl.Size = new System.Drawing.Size(76, 13);
            this.nevLbl.TabIndex = 4;
            this.nevLbl.Text = "Ajándék neve:";
            // 
            // uzletLbl
            // 
            this.uzletLbl.AutoSize = true;
            this.uzletLbl.Location = new System.Drawing.Point(75, 344);
            this.uzletLbl.Name = "uzletLbl";
            this.uzletLbl.Size = new System.Drawing.Size(34, 13);
            this.uzletLbl.TabIndex = 5;
            this.uzletLbl.Text = "Üzlet:";
            // 
            // mentesBtn
            // 
            this.mentesBtn.Location = new System.Drawing.Point(114, 406);
            this.mentesBtn.Name = "mentesBtn";
            this.mentesBtn.Size = new System.Drawing.Size(113, 27);
            this.mentesBtn.TabIndex = 6;
            this.mentesBtn.Text = "Mentés";
            this.mentesBtn.UseVisualStyleBackColor = true;
            this.mentesBtn.Click += new System.EventHandler(this.mentesBtn_Click);
            // 
            // torlesBtn
            // 
            this.torlesBtn.Location = new System.Drawing.Point(248, 185);
            this.torlesBtn.Name = "torlesBtn";
            this.torlesBtn.Size = new System.Drawing.Size(113, 27);
            this.torlesBtn.TabIndex = 7;
            this.torlesBtn.Text = "Törlés";
            this.torlesBtn.UseVisualStyleBackColor = true;
            this.torlesBtn.Visible = false;
            this.torlesBtn.Click += new System.EventHandler(this.torlesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.torlesBtn);
            this.Controls.Add(this.mentesBtn);
            this.Controls.Add(this.uzletLbl);
            this.Controls.Add(this.nevLbl);
            this.Controls.Add(this.uzletTB);
            this.Controls.Add(this.nevTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ajandekLstBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ajandekLstBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nevTB;
        private System.Windows.Forms.TextBox uzletTB;
        private System.Windows.Forms.Label nevLbl;
        private System.Windows.Forms.Label uzletLbl;
        private System.Windows.Forms.Button mentesBtn;
        private System.Windows.Forms.Button torlesBtn;
    }
}

