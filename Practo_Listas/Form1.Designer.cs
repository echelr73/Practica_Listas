namespace Practo_Listas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbAnimales = new System.Windows.Forms.TextBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.lbAnimales = new System.Windows.Forms.ListBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEliminarTodo = new System.Windows.Forms.Button();
            this.cbOrdenado = new System.Windows.Forms.CheckBox();
            this.lCantAnimales = new System.Windows.Forms.Label();
            this.lCapLista = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animales:";
            // 
            // tbAnimales
            // 
            this.tbAnimales.Location = new System.Drawing.Point(92, 30);
            this.tbAnimales.Name = "tbAnimales";
            this.tbAnimales.Size = new System.Drawing.Size(100, 20);
            this.tbAnimales.TabIndex = 1;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(217, 28);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.Text = "&Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // lbAnimales
            // 
            this.lbAnimales.FormattingEnabled = true;
            this.lbAnimales.Location = new System.Drawing.Point(37, 78);
            this.lbAnimales.Name = "lbAnimales";
            this.lbAnimales.Size = new System.Drawing.Size(176, 212);
            this.lbAnimales.TabIndex = 3;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(217, 167);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 2;
            this.bEliminar.Text = "&Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEliminarTodo
            // 
            this.bEliminarTodo.Location = new System.Drawing.Point(217, 210);
            this.bEliminarTodo.Name = "bEliminarTodo";
            this.bEliminarTodo.Size = new System.Drawing.Size(75, 23);
            this.bEliminarTodo.TabIndex = 2;
            this.bEliminarTodo.Text = "&Borrar Todo";
            this.bEliminarTodo.UseVisualStyleBackColor = true;
            // 
            // cbOrdenado
            // 
            this.cbOrdenado.AutoSize = true;
            this.cbOrdenado.Location = new System.Drawing.Point(219, 273);
            this.cbOrdenado.Name = "cbOrdenado";
            this.cbOrdenado.Size = new System.Drawing.Size(64, 17);
            this.cbOrdenado.TabIndex = 4;
            this.cbOrdenado.Text = "Ordenar";
            this.cbOrdenado.UseVisualStyleBackColor = true;
            this.cbOrdenado.CheckedChanged += new System.EventHandler(this.cbOrdenado_CheckedChanged);
            // 
            // lCantAnimales
            // 
            this.lCantAnimales.AutoSize = true;
            this.lCantAnimales.Location = new System.Drawing.Point(34, 317);
            this.lCantAnimales.Name = "lCantAnimales";
            this.lCantAnimales.Size = new System.Drawing.Size(112, 13);
            this.lCantAnimales.TabIndex = 0;
            this.lCantAnimales.Text = "Cantidad de Animales:";
            // 
            // lCapLista
            // 
            this.lCapLista.AutoSize = true;
            this.lCapLista.Location = new System.Drawing.Point(34, 340);
            this.lCapLista.Name = "lCapLista";
            this.lCapLista.Size = new System.Drawing.Size(108, 13);
            this.lCapLista.TabIndex = 0;
            this.lCapLista.Text = "Capacidad de la lista:";
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(367, 340);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 2;
            this.bCerrar.Text = "&Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.bAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCerrar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbOrdenado);
            this.Controls.Add(this.lbAnimales);
            this.Controls.Add(this.bEliminarTodo);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.tbAnimales);
            this.Controls.Add(this.lCapLista);
            this.Controls.Add(this.lCantAnimales);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAnimales;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.ListBox lbAnimales;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bEliminarTodo;
        private System.Windows.Forms.CheckBox cbOrdenado;
        private System.Windows.Forms.Label lCantAnimales;
        private System.Windows.Forms.Label lCapLista;
        private System.Windows.Forms.Button bCerrar;
    }
}

