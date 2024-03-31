
namespace _1_Game_of_life
{
    partial class game
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
            this.components = new System.ComponentModel.Container();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.Bluecolor = new System.Windows.Forms.Button();
            this.Redcolor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.LightPink;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_button.Location = new System.Drawing.Point(797, 409);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 60);
            this.start_button.TabIndex = 4;
            this.start_button.Text = "Начать";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click_1);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.LightPink;
            this.stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_button.Location = new System.Drawing.Point(797, 488);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 60);
            this.stop_button.TabIndex = 5;
            this.stop_button.Text = "Стоп";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // Bluecolor
            // 
            this.Bluecolor.BackColor = System.Drawing.Color.SlateBlue;
            this.Bluecolor.Location = new System.Drawing.Point(797, 101);
            this.Bluecolor.Margin = new System.Windows.Forms.Padding(2);
            this.Bluecolor.Name = "Bluecolor";
            this.Bluecolor.Size = new System.Drawing.Size(80, 40);
            this.Bluecolor.TabIndex = 6;
            this.Bluecolor.UseVisualStyleBackColor = false;
            this.Bluecolor.Click += new System.EventHandler(this.bluecolor_Click);
            // 
            // Redcolor
            // 
            this.Redcolor.BackColor = System.Drawing.Color.IndianRed;
            this.Redcolor.Location = new System.Drawing.Point(797, 41);
            this.Redcolor.Margin = new System.Windows.Forms.Padding(2);
            this.Redcolor.Name = "Redcolor";
            this.Redcolor.Size = new System.Drawing.Size(80, 40);
            this.Redcolor.TabIndex = 7;
            this.Redcolor.UseVisualStyleBackColor = false;
            this.Redcolor.Click += new System.EventHandler(this.redcolor_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 536);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Redcolor);
            this.Controls.Add(this.Bluecolor);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.stop_button);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "game";
            this.Text = "Жизнь";
           
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button Bluecolor;
        private System.Windows.Forms.Button Redcolor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}

