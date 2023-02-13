namespace Bloco_de_Notas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStripArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaJanelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configurarPáginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarComGoogleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarPróximoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subistituirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.váParaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datahoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ampliarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicarZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quebraDeLinhaAutomáticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Infos = new System.Windows.Forms.StatusStrip();
            this.labelCodificacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelFormato = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelCursor = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.Infos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripArquivo,
            this.MenuStripEditar,
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStripArquivo
            // 
            this.MenuStripArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.novaJanelaToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.configurarPáginaToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem});
            this.MenuStripArquivo.Name = "MenuStripArquivo";
            this.MenuStripArquivo.Size = new System.Drawing.Size(61, 20);
            this.MenuStripArquivo.Text = "&Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // novaJanelaToolStripMenuItem
            // 
            this.novaJanelaToolStripMenuItem.Name = "novaJanelaToolStripMenuItem";
            this.novaJanelaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.novaJanelaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.novaJanelaToolStripMenuItem.Text = "Nova Janela";
            this.novaJanelaToolStripMenuItem.Click += new System.EventHandler(this.novaJanelaToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.abrirToolStripMenuItem.Text = "Abrir...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // configurarPáginaToolStripMenuItem
            // 
            this.configurarPáginaToolStripMenuItem.Name = "configurarPáginaToolStripMenuItem";
            this.configurarPáginaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.configurarPáginaToolStripMenuItem.Text = "Configurar Página...";
            this.configurarPáginaToolStripMenuItem.Click += new System.EventHandler(this.configurarPáginaToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir...";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // MenuStripEditar
            // 
            this.MenuStripEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.recortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.buscarComGoogleToolStripMenuItem,
            this.localizarToolStripMenuItem,
            this.localizarPróximoToolStripMenuItem,
            this.localizarAnteriorToolStripMenuItem,
            this.subistituirToolStripMenuItem,
            this.váParaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.selecionarTudoToolStripMenuItem,
            this.datahoraToolStripMenuItem,
            this.toolStripMenuItem4,
            this.fonteToolStripMenuItem});
            this.MenuStripEditar.Name = "MenuStripEditar";
            this.MenuStripEditar.Size = new System.Drawing.Size(49, 20);
            this.MenuStripEditar.Text = "&Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            this.desfazerToolStripMenuItem.Click += new System.EventHandler(this.desfazerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(222, 6);
            // 
            // buscarComGoogleToolStripMenuItem
            // 
            this.buscarComGoogleToolStripMenuItem.Name = "buscarComGoogleToolStripMenuItem";
            this.buscarComGoogleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.buscarComGoogleToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.buscarComGoogleToolStripMenuItem.Text = "Buscar com google...";
            this.buscarComGoogleToolStripMenuItem.Click += new System.EventHandler(this.buscarComGoogleToolStripMenuItem_Click);
            // 
            // localizarToolStripMenuItem
            // 
            this.localizarToolStripMenuItem.Name = "localizarToolStripMenuItem";
            this.localizarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.localizarToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.localizarToolStripMenuItem.Text = "Localizar";
            this.localizarToolStripMenuItem.Click += new System.EventHandler(this.localizarToolStripMenuItem_Click);
            // 
            // localizarPróximoToolStripMenuItem
            // 
            this.localizarPróximoToolStripMenuItem.Name = "localizarPróximoToolStripMenuItem";
            this.localizarPróximoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.localizarPróximoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.localizarPróximoToolStripMenuItem.Text = "Localizar Próximo";
            // 
            // localizarAnteriorToolStripMenuItem
            // 
            this.localizarAnteriorToolStripMenuItem.Name = "localizarAnteriorToolStripMenuItem";
            this.localizarAnteriorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.localizarAnteriorToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.localizarAnteriorToolStripMenuItem.Text = "Localizar anterior";
            // 
            // subistituirToolStripMenuItem
            // 
            this.subistituirToolStripMenuItem.Name = "subistituirToolStripMenuItem";
            this.subistituirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.subistituirToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.subistituirToolStripMenuItem.Text = "Subistituir";
            // 
            // váParaToolStripMenuItem
            // 
            this.váParaToolStripMenuItem.Name = "váParaToolStripMenuItem";
            this.váParaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.váParaToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.váParaToolStripMenuItem.Text = "Vá para";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(222, 6);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar tudo";
            this.selecionarTudoToolStripMenuItem.Click += new System.EventHandler(this.selecionarTudoToolStripMenuItem_Click);
            // 
            // datahoraToolStripMenuItem
            // 
            this.datahoraToolStripMenuItem.Name = "datahoraToolStripMenuItem";
            this.datahoraToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.datahoraToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.datahoraToolStripMenuItem.Text = "Data/hora";
            this.datahoraToolStripMenuItem.Click += new System.EventHandler(this.datahoraToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(222, 6);
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.fonteToolStripMenuItem.Text = "Fonte";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.fonteToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ampliarToolStripMenuItem,
            this.barraDeStatusToolStripMenuItem,
            this.quebraDeLinhaAutomáticaToolStripMenuItem,
            this.corToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // ampliarToolStripMenuItem
            // 
            this.ampliarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicarZoomToolStripMenuItem,
            this.reduzirToolStripMenuItem,
            this.restaurarZoomToolStripMenuItem});
            this.ampliarToolStripMenuItem.Name = "ampliarToolStripMenuItem";
            this.ampliarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ampliarToolStripMenuItem.Text = "Ampliar";
            // 
            // aplicarZoomToolStripMenuItem
            // 
            this.aplicarZoomToolStripMenuItem.Name = "aplicarZoomToolStripMenuItem";
            this.aplicarZoomToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+ sinal de adição";
            this.aplicarZoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.aplicarZoomToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.aplicarZoomToolStripMenuItem.Text = "Aplicar zoom";
            this.aplicarZoomToolStripMenuItem.Click += new System.EventHandler(this.aplicarZoomToolStripMenuItem_Click);
            // 
            // reduzirToolStripMenuItem
            // 
            this.reduzirToolStripMenuItem.Name = "reduzirToolStripMenuItem";
            this.reduzirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + sinal de subtração";
            this.reduzirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.reduzirToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.reduzirToolStripMenuItem.Text = "Reduzir";
            this.reduzirToolStripMenuItem.Click += new System.EventHandler(this.reduzirToolStripMenuItem_Click);
            // 
            // restaurarZoomToolStripMenuItem
            // 
            this.restaurarZoomToolStripMenuItem.Name = "restaurarZoomToolStripMenuItem";
            this.restaurarZoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.restaurarZoomToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.restaurarZoomToolStripMenuItem.Text = "Restaurar zoom";
            this.restaurarZoomToolStripMenuItem.Click += new System.EventHandler(this.restaurarZoomToolStripMenuItem_Click);
            // 
            // barraDeStatusToolStripMenuItem
            // 
            this.barraDeStatusToolStripMenuItem.Name = "barraDeStatusToolStripMenuItem";
            this.barraDeStatusToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.barraDeStatusToolStripMenuItem.Text = "Barra de Status";
            this.barraDeStatusToolStripMenuItem.Click += new System.EventHandler(this.barraDeStatusToolStripMenuItem_Click);
            // 
            // quebraDeLinhaAutomáticaToolStripMenuItem
            // 
            this.quebraDeLinhaAutomáticaToolStripMenuItem.Name = "quebraDeLinhaAutomáticaToolStripMenuItem";
            this.quebraDeLinhaAutomáticaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.quebraDeLinhaAutomáticaToolStripMenuItem.Text = "Quebra de linha automática";
            this.quebraDeLinhaAutomáticaToolStripMenuItem.Click += new System.EventHandler(this.quebraDeLinhaAutomáticaToolStripMenuItem_Click);
            // 
            // corToolStripMenuItem
            // 
            this.corToolStripMenuItem.Name = "corToolStripMenuItem";
            this.corToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.corToolStripMenuItem.Text = "Cor";
            this.corToolStripMenuItem.Click += new System.EventHandler(this.corToolStripMenuItem_Click);
            // 
            // Infos
            // 
            this.Infos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelCodificacao,
            this.labelFormato,
            this.labelZoom,
            this.labelCursor});
            this.Infos.Location = new System.Drawing.Point(0, 366);
            this.Infos.Name = "Infos";
            this.Infos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Infos.Size = new System.Drawing.Size(800, 24);
            this.Infos.TabIndex = 1;
            this.Infos.Text = "statusStrip1";
            this.Infos.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Infos_ItemClicked);
            // 
            // labelCodificacao
            // 
            this.labelCodificacao.Name = "labelCodificacao";
            this.labelCodificacao.Size = new System.Drawing.Size(38, 19);
            this.labelCodificacao.Text = "UTF-8";
            // 
            // labelFormato
            // 
            this.labelFormato.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.labelFormato.Name = "labelFormato";
            this.labelFormato.Size = new System.Drawing.Size(109, 19);
            this.labelFormato.Text = "Windows (CR - LF)";
            // 
            // labelZoom
            // 
            this.labelZoom.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(39, 19);
            this.labelZoom.Text = "100%";
            // 
            // labelCursor
            // 
            this.labelCursor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.labelCursor.Name = "labelCursor";
            this.labelCursor.Size = new System.Drawing.Size(90, 19);
            this.labelCursor.Text = "Linha: Coluna: ";
            // 
            // TextBox
            // 
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(0, 24);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(800, 342);
            this.TextBox.TabIndex = 2;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Arquivo de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "Área de Trabalho";
            this.openFileDialog1.Title = "Abrir arquivo";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Arquivo de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
            this.saveFileDialog1.Title = "Salvar Como";
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Infos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bloco de Notas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Infos.ResumeLayout(false);
            this.Infos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStripArquivo;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuStripEditar;
        private System.Windows.Forms.StatusStrip Infos;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.ToolStripMenuItem novaJanelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarPáginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem localizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarPróximoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subistituirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem váParaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datahoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ampliarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicarZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduzirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraDeStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quebraDeLinhaAutomáticaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem buscarComGoogleToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripStatusLabel labelCodificacao;
        private System.Windows.Forms.ToolStripStatusLabel labelFormato;
        private System.Windows.Forms.ToolStripStatusLabel labelZoom;
        private System.Windows.Forms.ToolStripStatusLabel labelCursor;
        private System.Windows.Forms.ToolStripMenuItem corToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

