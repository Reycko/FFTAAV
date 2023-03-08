namespace FFTAAV
{
    partial class FFTAAV
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.ffmpegLoc = new System.Windows.Forms.TextBox();
            this.ffmpegLoc_Label = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.input_Label = new System.Windows.Forms.Label();
            this.res_Label = new System.Windows.Forms.Label();
            this.res1 = new System.Windows.Forms.TextBox();
            this.output_Label = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.res2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GenButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to FFTAAV!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ffmpegLoc
            // 
            this.ffmpegLoc.Location = new System.Drawing.Point(180, 70);
            this.ffmpegLoc.Name = "ffmpegLoc";
            this.ffmpegLoc.Size = new System.Drawing.Size(250, 20);
            this.ffmpegLoc.TabIndex = 1;
            this.ffmpegLoc.Text = "ffmpeg";
            // 
            // ffmpegLoc_Label
            // 
            this.ffmpegLoc_Label.AutoSize = true;
            this.ffmpegLoc_Label.Location = new System.Drawing.Point(86, 73);
            this.ffmpegLoc_Label.Name = "ffmpegLoc_Label";
            this.ffmpegLoc_Label.Size = new System.Drawing.Size(88, 13);
            this.ffmpegLoc_Label.TabIndex = 2;
            this.ffmpegLoc_Label.Text = "FFmpeg location:";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(180, 119);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(250, 20);
            this.input.TabIndex = 3;
            this.input.Text = "input";
            // 
            // input_Label
            // 
            this.input_Label.AutoSize = true;
            this.input_Label.Location = new System.Drawing.Point(140, 122);
            this.input_Label.Name = "input_Label";
            this.input_Label.Size = new System.Drawing.Size(34, 13);
            this.input_Label.TabIndex = 4;
            this.input_Label.Text = "Input:";
            // 
            // res_Label
            // 
            this.res_Label.AutoSize = true;
            this.res_Label.Location = new System.Drawing.Point(114, 215);
            this.res_Label.Name = "res_Label";
            this.res_Label.Size = new System.Drawing.Size(60, 13);
            this.res_Label.TabIndex = 8;
            this.res_Label.Text = "Resolution:";
            // 
            // res1
            // 
            this.res1.Location = new System.Drawing.Point(180, 212);
            this.res1.Name = "res1";
            this.res1.Size = new System.Drawing.Size(67, 20);
            this.res1.TabIndex = 7;
            this.res1.Text = "240";
            // 
            // output_Label
            // 
            this.output_Label.AutoSize = true;
            this.output_Label.Location = new System.Drawing.Point(132, 166);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(42, 13);
            this.output_Label.TabIndex = 6;
            this.output_Label.Text = "Output:";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(180, 163);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(250, 20);
            this.output.TabIndex = 5;
            this.output.Text = "output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "x";
            // 
            // res2
            // 
            this.res2.Location = new System.Drawing.Point(271, 212);
            this.res2.Name = "res2";
            this.res2.Size = new System.Drawing.Size(62, 20);
            this.res2.TabIndex = 10;
            this.res2.Text = "240";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "(Default is recommended if you want to upload online)";
            // 
            // GenButton
            // 
            this.GenButton.Location = new System.Drawing.Point(180, 297);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(250, 62);
            this.GenButton.TabIndex = 12;
            this.GenButton.Text = "Create!";
            this.GenButton.UseVisualStyleBackColor = true;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = ".mp4";
            // 
            // FFTAAV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 397);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.res2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.res_Label);
            this.Controls.Add(this.res1);
            this.Controls.Add(this.output_Label);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input_Label);
            this.Controls.Add(this.input);
            this.Controls.Add(this.ffmpegLoc_Label);
            this.Controls.Add(this.ffmpegLoc);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FFTAAV";
            this.Text = "FFTAAV - Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ffmpegLoc;
        private System.Windows.Forms.Label ffmpegLoc_Label;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label input_Label;
        private System.Windows.Forms.Label res_Label;
        private System.Windows.Forms.TextBox res1;
        private System.Windows.Forms.Label output_Label;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox res2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GenButton;
        private System.Windows.Forms.Label label5;
    }
}

