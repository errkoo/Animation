namespace Animation
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy_3 = new System.Windows.Forms.PictureBox();
            this.enemy_2 = new System.Windows.Forms.PictureBox();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player
            // 
            this.player.Image = global::Animation.Properties.Resources.mario;
            this.player.Location = new System.Drawing.Point(681, 329);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(197, 237);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // enemy_3
            // 
            this.enemy_3.Image = global::Animation.Properties.Resources.bad_mushroom;
            this.enemy_3.Location = new System.Drawing.Point(1332, 360);
            this.enemy_3.Name = "enemy_3";
            this.enemy_3.Size = new System.Drawing.Size(190, 173);
            this.enemy_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_3.TabIndex = 2;
            this.enemy_3.TabStop = false;
            // 
            // enemy_2
            // 
            this.enemy_2.Image = global::Animation.Properties.Resources.bad_mushroom;
            this.enemy_2.Location = new System.Drawing.Point(21, 670);
            this.enemy_2.Name = "enemy_2";
            this.enemy_2.Size = new System.Drawing.Size(190, 173);
            this.enemy_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_2.TabIndex = 1;
            this.enemy_2.TabStop = false;
            // 
            // enemy_1
            // 
            this.enemy_1.Image = global::Animation.Properties.Resources.bad_mushroom;
            this.enemy_1.Location = new System.Drawing.Point(12, 27);
            this.enemy_1.Name = "enemy_1";
            this.enemy_1.Size = new System.Drawing.Size(190, 173);
            this.enemy_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_1.TabIndex = 0;
            this.enemy_1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 1001);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemy_3);
            this.Controls.Add(this.enemy_2);
            this.Controls.Add(this.enemy_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox enemy_2;
        private System.Windows.Forms.PictureBox enemy_3;
        private System.Windows.Forms.PictureBox player;
    }
}

