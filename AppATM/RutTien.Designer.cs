
namespace AppATM
{
    partial class RutTien
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
            this.txtSoTienDu = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblSoTienRut = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSoTienDu
            // 
            this.txtSoTienDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienDu.Location = new System.Drawing.Point(52, 71);
            this.txtSoTienDu.Name = "txtSoTienDu";
            this.txtSoTienDu.Size = new System.Drawing.Size(209, 27);
            this.txtSoTienDu.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuy.ForeColor = System.Drawing.Color.Blue;
            this.btnHuy.Location = new System.Drawing.Point(41, 136);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 33);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblSoTienRut
            // 
            this.lblSoTienRut.AutoSize = true;
            this.lblSoTienRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTienRut.Location = new System.Drawing.Point(92, 26);
            this.lblSoTienRut.Name = "lblSoTienRut";
            this.lblSoTienRut.Size = new System.Drawing.Size(121, 22);
            this.lblSoTienRut.TabIndex = 2;
            this.lblSoTienRut.Text = "Nhập Số Tiền";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Aqua;
            this.btnOk.ForeColor = System.Drawing.Color.Purple;
            this.btnOk.Location = new System.Drawing.Point(191, 136);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 33);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Xác nhận";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // RutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 243);
            this.Controls.Add(this.lblSoTienRut);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtSoTienDu);
            this.Name = "RutTien";
            this.Text = "Rút Tiền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoTienDu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblSoTienRut;
        private System.Windows.Forms.Button btnOk;
    }
}