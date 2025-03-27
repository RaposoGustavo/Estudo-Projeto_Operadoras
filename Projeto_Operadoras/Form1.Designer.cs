namespace Projeto_Operadoras
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lb_Titulo = new System.Windows.Forms.Label();
            this.Gb_operadoras = new System.Windows.Forms.GroupBox();
            this.Rb_TIM = new System.Windows.Forms.RadioButton();
            this.Rb_vivo = new System.Windows.Forms.RadioButton();
            this.Rb_claro = new System.Windows.Forms.RadioButton();
            this.Rb_oi = new System.Windows.Forms.RadioButton();
            this.Lb_titulo2 = new System.Windows.Forms.Label();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.Lb_nome = new System.Windows.Forms.Label();
            this.Lb_operadora = new System.Windows.Forms.Label();
            this.Txt_operadora = new System.Windows.Forms.TextBox();
            this.Lb_ddd = new System.Windows.Forms.Label();
            this.Lb_numero = new System.Windows.Forms.Label();
            this.Lb_valor = new System.Windows.Forms.Label();
            this.Txt_ddd = new System.Windows.Forms.TextBox();
            this.Txt_numero = new System.Windows.Forms.TextBox();
            this.Txt_vlrecarga = new System.Windows.Forms.TextBox();
            this.Btn_valor1 = new System.Windows.Forms.Button();
            this.Btn_valor2 = new System.Windows.Forms.Button();
            this.Btn_valor3 = new System.Windows.Forms.Button();
            this.Btn_valor4 = new System.Windows.Forms.Button();
            this.Btn_valor5 = new System.Windows.Forms.Button();
            this.Btn_valor6 = new System.Windows.Forms.Button();
            this.Btn_valor7 = new System.Windows.Forms.Button();
            this.Btn_valor8 = new System.Windows.Forms.Button();
            this.Lb_validade4 = new System.Windows.Forms.Label();
            this.Lb_validade3 = new System.Windows.Forms.Label();
            this.Lb_validade2 = new System.Windows.Forms.Label();
            this.Lb_validade1 = new System.Windows.Forms.Label();
            this.Lb_validade5 = new System.Windows.Forms.Label();
            this.Lb_validade6 = new System.Windows.Forms.Label();
            this.Lb_validade7 = new System.Windows.Forms.Label();
            this.Lb_validade8 = new System.Windows.Forms.Label();
            this.Btn_recarregar = new System.Windows.Forms.Button();
            this.Lbl_recarcagaRalaizada = new System.Windows.Forms.Label();
            this.Lbl_dados = new System.Windows.Forms.Label();
            this.Btn_novaRecarga = new System.Windows.Forms.Button();
            this.Pic_imagem = new System.Windows.Forms.PictureBox();
            this.Gb_operadoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Titulo
            // 
            this.Lb_Titulo.AutoSize = true;
            this.Lb_Titulo.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Titulo.Location = new System.Drawing.Point(379, 101);
            this.Lb_Titulo.Name = "Lb_Titulo";
            this.Lb_Titulo.Size = new System.Drawing.Size(246, 34);
            this.Lb_Titulo.TabIndex = 0;
            this.Lb_Titulo.Text = "Dados da Recarga";
            // 
            // Gb_operadoras
            // 
            this.Gb_operadoras.Controls.Add(this.Rb_TIM);
            this.Gb_operadoras.Controls.Add(this.Rb_vivo);
            this.Gb_operadoras.Controls.Add(this.Rb_claro);
            this.Gb_operadoras.Controls.Add(this.Rb_oi);
            this.Gb_operadoras.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_operadoras.Location = new System.Drawing.Point(12, 177);
            this.Gb_operadoras.Name = "Gb_operadoras";
            this.Gb_operadoras.Size = new System.Drawing.Size(151, 255);
            this.Gb_operadoras.TabIndex = 1;
            this.Gb_operadoras.TabStop = false;
            this.Gb_operadoras.Text = "Operadoras";
            // 
            // Rb_TIM
            // 
            this.Rb_TIM.AutoSize = true;
            this.Rb_TIM.Location = new System.Drawing.Point(27, 144);
            this.Rb_TIM.Name = "Rb_TIM";
            this.Rb_TIM.Size = new System.Drawing.Size(57, 25);
            this.Rb_TIM.TabIndex = 2;
            this.Rb_TIM.Text = "TIM";
            this.Rb_TIM.UseVisualStyleBackColor = true;
            this.Rb_TIM.CheckedChanged += new System.EventHandler(this.Rb_TIM_CheckedChanged);
            // 
            // Rb_vivo
            // 
            this.Rb_vivo.AutoSize = true;
            this.Rb_vivo.Location = new System.Drawing.Point(27, 38);
            this.Rb_vivo.Name = "Rb_vivo";
            this.Rb_vivo.Size = new System.Drawing.Size(67, 25);
            this.Rb_vivo.TabIndex = 3;
            this.Rb_vivo.Text = "VIVO";
            this.Rb_vivo.UseVisualStyleBackColor = true;
            this.Rb_vivo.CheckedChanged += new System.EventHandler(this.Rb_vivo_CheckedChanged);
            // 
            // Rb_claro
            // 
            this.Rb_claro.AutoSize = true;
            this.Rb_claro.Location = new System.Drawing.Point(27, 93);
            this.Rb_claro.Name = "Rb_claro";
            this.Rb_claro.Size = new System.Drawing.Size(79, 25);
            this.Rb_claro.TabIndex = 4;
            this.Rb_claro.Text = "CLARO";
            this.Rb_claro.UseVisualStyleBackColor = true;
            this.Rb_claro.CheckedChanged += new System.EventHandler(this.Rb_claro_CheckedChanged);
            // 
            // Rb_oi
            // 
            this.Rb_oi.AutoSize = true;
            this.Rb_oi.Location = new System.Drawing.Point(28, 195);
            this.Rb_oi.Name = "Rb_oi";
            this.Rb_oi.Size = new System.Drawing.Size(45, 25);
            this.Rb_oi.TabIndex = 5;
            this.Rb_oi.Text = "OI";
            this.Rb_oi.UseVisualStyleBackColor = true;
            this.Rb_oi.CheckedChanged += new System.EventHandler(this.Rb_oi_CheckedChanged);
            // 
            // Lb_titulo2
            // 
            this.Lb_titulo2.AutoSize = true;
            this.Lb_titulo2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_titulo2.Location = new System.Drawing.Point(266, 204);
            this.Lb_titulo2.Name = "Lb_titulo2";
            this.Lb_titulo2.Size = new System.Drawing.Size(147, 23);
            this.Lb_titulo2.TabIndex = 2;
            this.Lb_titulo2.Text = "Seja Bem-vindo!";
            // 
            // Txt_nome
            // 
            this.Txt_nome.Enabled = false;
            this.Txt_nome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nome.Location = new System.Drawing.Point(419, 203);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(437, 28);
            this.Txt_nome.TabIndex = 3;
            // 
            // Lb_nome
            // 
            this.Lb_nome.AutoSize = true;
            this.Lb_nome.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_nome.Location = new System.Drawing.Point(415, 177);
            this.Lb_nome.Name = "Lb_nome";
            this.Lb_nome.Size = new System.Drawing.Size(65, 23);
            this.Lb_nome.TabIndex = 4;
            this.Lb_nome.Text = "Nome:";
            // 
            // Lb_operadora
            // 
            this.Lb_operadora.AutoSize = true;
            this.Lb_operadora.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_operadora.Location = new System.Drawing.Point(415, 250);
            this.Lb_operadora.Name = "Lb_operadora";
            this.Lb_operadora.Size = new System.Drawing.Size(210, 23);
            this.Lb_operadora.TabIndex = 5;
            this.Lb_operadora.Text = "Operadora selecionada:";
            // 
            // Txt_operadora
            // 
            this.Txt_operadora.Enabled = false;
            this.Txt_operadora.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_operadora.Location = new System.Drawing.Point(631, 245);
            this.Txt_operadora.Name = "Txt_operadora";
            this.Txt_operadora.Size = new System.Drawing.Size(100, 28);
            this.Txt_operadora.TabIndex = 6;
            this.Txt_operadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lb_ddd
            // 
            this.Lb_ddd.AutoSize = true;
            this.Lb_ddd.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ddd.Location = new System.Drawing.Point(416, 319);
            this.Lb_ddd.Name = "Lb_ddd";
            this.Lb_ddd.Size = new System.Drawing.Size(37, 16);
            this.Lb_ddd.TabIndex = 7;
            this.Lb_ddd.Text = "DDD:";
            // 
            // Lb_numero
            // 
            this.Lb_numero.AutoSize = true;
            this.Lb_numero.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_numero.Location = new System.Drawing.Point(545, 319);
            this.Lb_numero.Name = "Lb_numero";
            this.Lb_numero.Size = new System.Drawing.Size(120, 16);
            this.Lb_numero.TabIndex = 8;
            this.Lb_numero.Text = "Número do celular:";
            // 
            // Lb_valor
            // 
            this.Lb_valor.AutoSize = true;
            this.Lb_valor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_valor.Location = new System.Drawing.Point(754, 321);
            this.Lb_valor.Name = "Lb_valor";
            this.Lb_valor.Size = new System.Drawing.Size(109, 16);
            this.Lb_valor.TabIndex = 9;
            this.Lb_valor.Text = "Valor de recarga:";
            // 
            // Txt_ddd
            // 
            this.Txt_ddd.Enabled = false;
            this.Txt_ddd.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ddd.Location = new System.Drawing.Point(419, 338);
            this.Txt_ddd.Name = "Txt_ddd";
            this.Txt_ddd.Size = new System.Drawing.Size(100, 24);
            this.Txt_ddd.TabIndex = 10;
            // 
            // Txt_numero
            // 
            this.Txt_numero.Enabled = false;
            this.Txt_numero.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numero.Location = new System.Drawing.Point(548, 340);
            this.Txt_numero.Name = "Txt_numero";
            this.Txt_numero.Size = new System.Drawing.Size(178, 24);
            this.Txt_numero.TabIndex = 11;
            // 
            // Txt_vlrecarga
            // 
            this.Txt_vlrecarga.Enabled = false;
            this.Txt_vlrecarga.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_vlrecarga.Location = new System.Drawing.Point(757, 340);
            this.Txt_vlrecarga.Name = "Txt_vlrecarga";
            this.Txt_vlrecarga.Size = new System.Drawing.Size(142, 24);
            this.Txt_vlrecarga.TabIndex = 12;
            // 
            // Btn_valor1
            // 
            this.Btn_valor1.BackColor = System.Drawing.Color.Transparent;
            this.Btn_valor1.Enabled = false;
            this.Btn_valor1.FlatAppearance.BorderSize = 0;
            this.Btn_valor1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_valor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_valor1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_valor1.ForeColor = System.Drawing.Color.Black;
            this.Btn_valor1.Location = new System.Drawing.Point(419, 422);
            this.Btn_valor1.Name = "Btn_valor1";
            this.Btn_valor1.Size = new System.Drawing.Size(123, 73);
            this.Btn_valor1.TabIndex = 13;
            this.Btn_valor1.Text = "R$";
            this.Btn_valor1.UseVisualStyleBackColor = false;
            this.Btn_valor1.Click += new System.EventHandler(this.Btn_valor1_Click);
            // 
            // Btn_valor2
            // 
            this.Btn_valor2.BackColor = System.Drawing.Color.Transparent;
            this.Btn_valor2.Enabled = false;
            this.Btn_valor2.FlatAppearance.BorderSize = 0;
            this.Btn_valor2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_valor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_valor2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_valor2.ForeColor = System.Drawing.Color.Black;
            this.Btn_valor2.Location = new System.Drawing.Point(548, 422);
            this.Btn_valor2.Name = "Btn_valor2";
            this.Btn_valor2.Size = new System.Drawing.Size(123, 73);
            this.Btn_valor2.TabIndex = 14;
            this.Btn_valor2.Text = "R$";
            this.Btn_valor2.UseVisualStyleBackColor = false;
            this.Btn_valor2.Click += new System.EventHandler(this.Btn_valor2_Click);
            // 
            // Btn_valor3
            // 
            this.Btn_valor3.BackColor = System.Drawing.Color.Transparent;
            this.Btn_valor3.Enabled = false;
            this.Btn_valor3.FlatAppearance.BorderSize = 0;
            this.Btn_valor3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_valor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_valor3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_valor3.ForeColor = System.Drawing.Color.Black;
            this.Btn_valor3.Location = new System.Drawing.Point(677, 422);
            this.Btn_valor3.Name = "Btn_valor3";
            this.Btn_valor3.Size = new System.Drawing.Size(123, 73);
            this.Btn_valor3.TabIndex = 15;
            this.Btn_valor3.Text = "R$";
            this.Btn_valor3.UseVisualStyleBackColor = false;
            this.Btn_valor3.Click += new System.EventHandler(this.Btn_valor3_Click);
            // 
            // Btn_valor4
            // 
            this.Btn_valor4.BackColor = System.Drawing.Color.Transparent;
            this.Btn_valor4.Enabled = false;
            this.Btn_valor4.FlatAppearance.BorderSize = 0;
            this.Btn_valor4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_valor4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_valor4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_valor4.ForeColor = System.Drawing.Color.Black;
            this.Btn_valor4.Location = new System.Drawing.Point(806, 422);
            this.Btn_valor4.Name = "Btn_valor4";
            this.Btn_valor4.Size = new System.Drawing.Size(123, 73);
            this.Btn_valor4.TabIndex = 16;
            this.Btn_valor4.Text = "R$";
            this.Btn_valor4.UseVisualStyleBackColor = false;
            this.Btn_valor4.Click += new System.EventHandler(this.Btn_valor4_Click);
            // 
            // Btn_valor5
            // 
            this.Btn_valor5.BackColor = System.Drawing.Color.Transparent;
            this.Btn_valor5.Enabled = false;
            this.Btn_valor5.FlatAppearance.BorderSize = 0;
            this.Btn_valor5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_valor5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_valor5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_valor5.ForeColor = System.Drawing.Color.Black;
            this.Btn_valor5.Location = new System.Drawing.Point(419, 563);
            this.Btn_valor5.Name = "Btn_valor5";
            this.Btn_valor5.Size = new System.Drawing.Size(123, 73);
            this.Btn_valor5.TabIndex = 17;
            this.Btn_valor5.Text = "R$";
            this.Btn_valor5.UseVisualStyleBackColor = false;
            this.Btn_valor5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Btn_valor6
            // 
            this.Btn_valor6.BackColor = System.Drawing.Color.Transparent;
            this.Btn_valor6.Enabled = false;
            this.Btn_valor6.FlatAppearance.BorderSize = 0;
            this.Btn_valor6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_valor6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_valor6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_valor6.ForeColor = System.Drawing.Color.Black;
            this.Btn_valor6.Location = new System.Drawing.Point(548, 563);
            this.Btn_valor6.Name = "Btn_valor6";
            this.Btn_valor6.Size = new System.Drawing.Size(123, 73);
            this.Btn_valor6.TabIndex = 18;
            this.Btn_valor6.Text = "R$";
            this.Btn_valor6.UseVisualStyleBackColor = false;
            this.Btn_valor6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Btn_valor7
            // 
            this.Btn_valor7.BackColor = System.Drawing.Color.Transparent;
            this.Btn_valor7.Enabled = false;
            this.Btn_valor7.FlatAppearance.BorderSize = 0;
            this.Btn_valor7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_valor7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_valor7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_valor7.ForeColor = System.Drawing.Color.Black;
            this.Btn_valor7.Location = new System.Drawing.Point(677, 563);
            this.Btn_valor7.Name = "Btn_valor7";
            this.Btn_valor7.Size = new System.Drawing.Size(123, 73);
            this.Btn_valor7.TabIndex = 19;
            this.Btn_valor7.Text = "R$";
            this.Btn_valor7.UseVisualStyleBackColor = false;
            this.Btn_valor7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Btn_valor8
            // 
            this.Btn_valor8.BackColor = System.Drawing.Color.Transparent;
            this.Btn_valor8.Enabled = false;
            this.Btn_valor8.FlatAppearance.BorderSize = 0;
            this.Btn_valor8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_valor8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_valor8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_valor8.ForeColor = System.Drawing.Color.Black;
            this.Btn_valor8.Location = new System.Drawing.Point(806, 563);
            this.Btn_valor8.Name = "Btn_valor8";
            this.Btn_valor8.Size = new System.Drawing.Size(123, 73);
            this.Btn_valor8.TabIndex = 20;
            this.Btn_valor8.Text = "R$";
            this.Btn_valor8.UseVisualStyleBackColor = false;
            this.Btn_valor8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Lb_validade4
            // 
            this.Lb_validade4.AutoSize = true;
            this.Lb_validade4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_validade4.Location = new System.Drawing.Point(837, 498);
            this.Lb_validade4.Name = "Lb_validade4";
            this.Lb_validade4.Size = new System.Drawing.Size(70, 21);
            this.Lb_validade4.TabIndex = 21;
            this.Lb_validade4.Text = "Validade";
            // 
            // Lb_validade3
            // 
            this.Lb_validade3.AutoSize = true;
            this.Lb_validade3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_validade3.Location = new System.Drawing.Point(710, 498);
            this.Lb_validade3.Name = "Lb_validade3";
            this.Lb_validade3.Size = new System.Drawing.Size(70, 21);
            this.Lb_validade3.TabIndex = 22;
            this.Lb_validade3.Text = "Validade";
            // 
            // Lb_validade2
            // 
            this.Lb_validade2.AutoSize = true;
            this.Lb_validade2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_validade2.Location = new System.Drawing.Point(576, 498);
            this.Lb_validade2.Name = "Lb_validade2";
            this.Lb_validade2.Size = new System.Drawing.Size(70, 21);
            this.Lb_validade2.TabIndex = 23;
            this.Lb_validade2.Text = "Validade";
            // 
            // Lb_validade1
            // 
            this.Lb_validade1.AutoSize = true;
            this.Lb_validade1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_validade1.Location = new System.Drawing.Point(449, 498);
            this.Lb_validade1.Name = "Lb_validade1";
            this.Lb_validade1.Size = new System.Drawing.Size(70, 21);
            this.Lb_validade1.TabIndex = 24;
            this.Lb_validade1.Text = "Validade";
            // 
            // Lb_validade5
            // 
            this.Lb_validade5.AutoSize = true;
            this.Lb_validade5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_validade5.Location = new System.Drawing.Point(449, 639);
            this.Lb_validade5.Name = "Lb_validade5";
            this.Lb_validade5.Size = new System.Drawing.Size(70, 21);
            this.Lb_validade5.TabIndex = 25;
            this.Lb_validade5.Text = "Validade";
            // 
            // Lb_validade6
            // 
            this.Lb_validade6.AutoSize = true;
            this.Lb_validade6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_validade6.Location = new System.Drawing.Point(576, 639);
            this.Lb_validade6.Name = "Lb_validade6";
            this.Lb_validade6.Size = new System.Drawing.Size(70, 21);
            this.Lb_validade6.TabIndex = 26;
            this.Lb_validade6.Text = "Validade";
            // 
            // Lb_validade7
            // 
            this.Lb_validade7.AutoSize = true;
            this.Lb_validade7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_validade7.Location = new System.Drawing.Point(710, 639);
            this.Lb_validade7.Name = "Lb_validade7";
            this.Lb_validade7.Size = new System.Drawing.Size(70, 21);
            this.Lb_validade7.TabIndex = 27;
            this.Lb_validade7.Text = "Validade";
            // 
            // Lb_validade8
            // 
            this.Lb_validade8.AutoSize = true;
            this.Lb_validade8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_validade8.Location = new System.Drawing.Point(837, 639);
            this.Lb_validade8.Name = "Lb_validade8";
            this.Lb_validade8.Size = new System.Drawing.Size(70, 21);
            this.Lb_validade8.TabIndex = 28;
            this.Lb_validade8.Text = "Validade";
            // 
            // Btn_recarregar
            // 
            this.Btn_recarregar.Enabled = false;
            this.Btn_recarregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_recarregar.FlatAppearance.BorderSize = 0;
            this.Btn_recarregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Btn_recarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_recarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_recarregar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_recarregar.Location = new System.Drawing.Point(12, 684);
            this.Btn_recarregar.Name = "Btn_recarregar";
            this.Btn_recarregar.Size = new System.Drawing.Size(123, 53);
            this.Btn_recarregar.TabIndex = 30;
            this.Btn_recarregar.Text = "Realizar recarga";
            this.Btn_recarregar.UseVisualStyleBackColor = true;
            this.Btn_recarregar.Click += new System.EventHandler(this.Btn_recarregar_Click);
            // 
            // Lbl_recarcagaRalaizada
            // 
            this.Lbl_recarcagaRalaizada.AutoSize = true;
            this.Lbl_recarcagaRalaizada.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_recarcagaRalaizada.Location = new System.Drawing.Point(141, 736);
            this.Lbl_recarcagaRalaizada.Name = "Lbl_recarcagaRalaizada";
            this.Lbl_recarcagaRalaizada.Size = new System.Drawing.Size(0, 23);
            this.Lbl_recarcagaRalaizada.TabIndex = 31;
            // 
            // Lbl_dados
            // 
            this.Lbl_dados.AutoSize = true;
            this.Lbl_dados.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dados.Location = new System.Drawing.Point(450, 689);
            this.Lbl_dados.Name = "Lbl_dados";
            this.Lbl_dados.Size = new System.Drawing.Size(162, 23);
            this.Lbl_dados.TabIndex = 32;
            this.Lbl_dados.Text = "Dados da recarga:";
            // 
            // Btn_novaRecarga
            // 
            this.Btn_novaRecarga.FlatAppearance.BorderSize = 0;
            this.Btn_novaRecarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_novaRecarga.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_novaRecarga.Location = new System.Drawing.Point(841, 684);
            this.Btn_novaRecarga.Name = "Btn_novaRecarga";
            this.Btn_novaRecarga.Size = new System.Drawing.Size(88, 55);
            this.Btn_novaRecarga.TabIndex = 33;
            this.Btn_novaRecarga.Text = "Nova recarga";
            this.Btn_novaRecarga.UseVisualStyleBackColor = true;
            this.Btn_novaRecarga.Click += new System.EventHandler(this.Btn_novaRecarga_Click);
            // 
            // Pic_imagem
            // 
            this.Pic_imagem.Image = ((System.Drawing.Image)(resources.GetObject("Pic_imagem.Image")));
            this.Pic_imagem.Location = new System.Drawing.Point(12, 491);
            this.Pic_imagem.Name = "Pic_imagem";
            this.Pic_imagem.Size = new System.Drawing.Size(327, 169);
            this.Pic_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_imagem.TabIndex = 29;
            this.Pic_imagem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(965, 749);
            this.Controls.Add(this.Btn_novaRecarga);
            this.Controls.Add(this.Lbl_dados);
            this.Controls.Add(this.Lbl_recarcagaRalaizada);
            this.Controls.Add(this.Btn_recarregar);
            this.Controls.Add(this.Pic_imagem);
            this.Controls.Add(this.Lb_validade8);
            this.Controls.Add(this.Lb_validade7);
            this.Controls.Add(this.Lb_validade6);
            this.Controls.Add(this.Lb_validade5);
            this.Controls.Add(this.Lb_validade1);
            this.Controls.Add(this.Lb_validade2);
            this.Controls.Add(this.Lb_validade3);
            this.Controls.Add(this.Lb_validade4);
            this.Controls.Add(this.Btn_valor8);
            this.Controls.Add(this.Btn_valor7);
            this.Controls.Add(this.Btn_valor6);
            this.Controls.Add(this.Btn_valor5);
            this.Controls.Add(this.Btn_valor4);
            this.Controls.Add(this.Btn_valor3);
            this.Controls.Add(this.Btn_valor2);
            this.Controls.Add(this.Btn_valor1);
            this.Controls.Add(this.Txt_vlrecarga);
            this.Controls.Add(this.Txt_numero);
            this.Controls.Add(this.Txt_ddd);
            this.Controls.Add(this.Lb_valor);
            this.Controls.Add(this.Lb_numero);
            this.Controls.Add(this.Lb_ddd);
            this.Controls.Add(this.Txt_operadora);
            this.Controls.Add(this.Lb_operadora);
            this.Controls.Add(this.Lb_nome);
            this.Controls.Add(this.Txt_nome);
            this.Controls.Add(this.Lb_titulo2);
            this.Controls.Add(this.Gb_operadoras);
            this.Controls.Add(this.Lb_Titulo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Recarga de operadoras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Gb_operadoras.ResumeLayout(false);
            this.Gb_operadoras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Titulo;
        private System.Windows.Forms.GroupBox Gb_operadoras;
        private System.Windows.Forms.RadioButton Rb_TIM;
        private System.Windows.Forms.RadioButton Rb_vivo;
        private System.Windows.Forms.RadioButton Rb_claro;
        private System.Windows.Forms.RadioButton Rb_oi;
        private System.Windows.Forms.Label Lb_titulo2;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Label Lb_nome;
        private System.Windows.Forms.Label Lb_operadora;
        private System.Windows.Forms.TextBox Txt_operadora;
        private System.Windows.Forms.Label Lb_ddd;
        private System.Windows.Forms.Label Lb_numero;
        private System.Windows.Forms.Label Lb_valor;
        private System.Windows.Forms.TextBox Txt_ddd;
        private System.Windows.Forms.TextBox Txt_numero;
        private System.Windows.Forms.TextBox Txt_vlrecarga;
        private System.Windows.Forms.Button Btn_valor1;
        private System.Windows.Forms.Button Btn_valor2;
        private System.Windows.Forms.Button Btn_valor3;
        private System.Windows.Forms.Button Btn_valor4;
        private System.Windows.Forms.Button Btn_valor5;
        private System.Windows.Forms.Button Btn_valor6;
        private System.Windows.Forms.Button Btn_valor7;
        private System.Windows.Forms.Button Btn_valor8;
        private System.Windows.Forms.Label Lb_validade4;
        private System.Windows.Forms.Label Lb_validade3;
        private System.Windows.Forms.Label Lb_validade2;
        private System.Windows.Forms.Label Lb_validade1;
        private System.Windows.Forms.Label Lb_validade5;
        private System.Windows.Forms.Label Lb_validade6;
        private System.Windows.Forms.Label Lb_validade7;
        private System.Windows.Forms.Label Lb_validade8;
        private System.Windows.Forms.PictureBox Pic_imagem;
        private System.Windows.Forms.Button Btn_recarregar;
        private System.Windows.Forms.Label Lbl_recarcagaRalaizada;
        private System.Windows.Forms.Label Lbl_dados;
        private System.Windows.Forms.Button Btn_novaRecarga;
    }
}

