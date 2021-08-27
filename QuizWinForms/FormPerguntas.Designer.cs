
namespace QuizWinForms
{
    partial class FormPerguntas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOp4 = new System.Windows.Forms.RadioButton();
            this.radioOp3 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioOp2 = new System.Windows.Forms.RadioButton();
            this.radioOp1 = new System.Windows.Forms.RadioButton();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.btnReiniciarQuiz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOp4);
            this.groupBox1.Controls.Add(this.radioOp3);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.radioOp2);
            this.groupBox1.Controls.Add(this.radioOp1);
            this.groupBox1.Location = new System.Drawing.Point(111, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioOp4
            // 
            this.radioOp4.AutoSize = true;
            this.radioOp4.Location = new System.Drawing.Point(18, 189);
            this.radioOp4.Name = "radioOp4";
            this.radioOp4.Size = new System.Drawing.Size(14, 13);
            this.radioOp4.TabIndex = 4;
            this.radioOp4.TabStop = true;
            this.radioOp4.Tag = "4";
            this.radioOp4.UseVisualStyleBackColor = true;
            // 
            // radioOp3
            // 
            this.radioOp3.AutoSize = true;
            this.radioOp3.Location = new System.Drawing.Point(18, 146);
            this.radioOp3.Name = "radioOp3";
            this.radioOp3.Size = new System.Drawing.Size(14, 13);
            this.radioOp3.TabIndex = 3;
            this.radioOp3.TabStop = true;
            this.radioOp3.Tag = "3";
            this.radioOp3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-20, 96);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(593, 44);
            this.progressBar1.TabIndex = 3;
            // 
            // radioOp2
            // 
            this.radioOp2.AutoSize = true;
            this.radioOp2.Location = new System.Drawing.Point(18, 99);
            this.radioOp2.Name = "radioOp2";
            this.radioOp2.Size = new System.Drawing.Size(14, 13);
            this.radioOp2.TabIndex = 2;
            this.radioOp2.TabStop = true;
            this.radioOp2.Tag = "2";
            this.radioOp2.UseVisualStyleBackColor = true;
            // 
            // radioOp1
            // 
            this.radioOp1.AutoSize = true;
            this.radioOp1.Location = new System.Drawing.Point(18, 50);
            this.radioOp1.Name = "radioOp1";
            this.radioOp1.Size = new System.Drawing.Size(14, 13);
            this.radioOp1.TabIndex = 1;
            this.radioOp1.TabStop = true;
            this.radioOp1.Tag = "1";
            this.radioOp1.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(515, 365);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(143, 43);
            this.btnProximo.TabIndex = 0;
            this.btnProximo.Text = "Avançar";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPergunta
            // 
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(111, 9);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(547, 71);
            this.lblPergunta.TabIndex = 2;
            this.lblPergunta.Text = "label1";
            this.lblPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReiniciarQuiz
            // 
            this.btnReiniciarQuiz.Location = new System.Drawing.Point(111, 365);
            this.btnReiniciarQuiz.Name = "btnReiniciarQuiz";
            this.btnReiniciarQuiz.Size = new System.Drawing.Size(143, 41);
            this.btnReiniciarQuiz.TabIndex = 4;
            this.btnReiniciarQuiz.Text = "Reiniciar Quiz";
            this.btnReiniciarQuiz.UseVisualStyleBackColor = true;
            this.btnReiniciarQuiz.Click += new System.EventHandler(this.btnReiniciarQuiz_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(720, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormPerguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReiniciarQuiz);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormPerguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPerguntas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOp4;
        private System.Windows.Forms.RadioButton radioOp3;
        private System.Windows.Forms.RadioButton radioOp2;
        private System.Windows.Forms.RadioButton radioOp1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnReiniciarQuiz;
        private System.Windows.Forms.Label label1;
    }
}