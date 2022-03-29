namespace Introduccion;

public partial class Form1 : Form
{
    private Label? lblFigura;
    private ComboBox? cmbFiguras;
    private Label? lblCalculo;
    private ComboBox? cmbCalculos;
    private Label? lblAltura;
    private TextBox? txtAltura;
    private Label? lblBase;
    private TextBox? txtBase;
    private Label? lblLadoA;
    private TextBox? txtLadoA;
    private Label? lblLadoB;
    private TextBox? txtLadoB;
    private Label? lblResultado;
    private TextBox? txtResultado;
    private Button? btnCalcular;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
        
    }
    private void InicializarComponentes()
    {
        // Tamaño de la ventana
        this.Size = new Size(500,550);

        //Etiqueta Figura
        lblFigura= new Label();
        lblFigura.Text="Figura";
        lblFigura.AutoSize=true;
        lblFigura.Location= new Point(10,10);

        //ComboBox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Selecciona figura");
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Triángulo");
        cmbFiguras.Items.Add("Rectángulo");
        cmbFiguras.SelectedIndex=0;
        cmbFiguras.Location= new Point(10,40);
        cmbFiguras.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Calculo
        lblCalculo= new Label();
        lblCalculo.Text="Cálculo";
        lblCalculo.AutoSize=true;
        lblCalculo.Location= new Point(150,10);

        //ComboBox Calculos
        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Selecciona calculo");
        cmbCalculos.Items.Add("Périmetro");
        cmbCalculos.Items.Add("Área");
        cmbCalculos.SelectedIndex=0;
        cmbCalculos.Location= new Point(150,40);
        cmbCalculos.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Altura
        lblAltura= new Label();
        lblAltura.Text="Altura";
        lblAltura.AutoSize=true;
        lblAltura.Location= new Point(10,80);
        lblAltura.Visible=false;

        //Etiqueta Base
        lblBase= new Label();
        lblBase.Text="Base";
        lblBase.AutoSize=true;
        lblBase.Location= new Point(10,120);
        lblBase.Visible=false;

        //Etiqueta Lado A
        lblLadoA= new Label();
        lblLadoA.Text="Lado A";
        lblLadoA.AutoSize=true;
        lblLadoA.Location= new Point(10,160);
        lblLadoA.Visible=false;

        //Etiqueta Lado B
        lblLadoB= new Label();
        lblLadoB.Text="Lado B";
        lblLadoB.AutoSize=true;
        lblLadoB.Location= new Point(10,200);
        lblLadoB.Visible=false;

        //TextBox Altura
        txtAltura=new TextBox();
        txtAltura.Size = new Size(100,20);
        txtAltura.Location= new Point(70,75);
        txtAltura.Visible=false;

        //TextBox Base
        txtBase=new TextBox();
        txtBase.Size = new Size(100,20);
        txtBase.Location= new Point(70,120);
        txtBase.Visible=false;

        //TextBox Lado A
        txtLadoA=new TextBox();
        txtLadoA.Size = new Size(100,20);
        txtLadoA.Location= new Point(80,165);
        txtLadoA.Visible=false;

        //TextBox Lado B
        txtLadoB=new TextBox();
        txtLadoB.Size = new Size(100,20);
        txtLadoB.Location= new Point(80,210);
        txtLadoB.Visible=false;

        //Etiqueta Altura
        lblResultado= new Label();
        lblResultado.Text="Resultado";
        lblResultado.AutoSize=true;
        lblResultado.Location= new Point(10,280);

        //TextBox Prueba
        txtResultado=new TextBox();
        txtResultado.Size = new Size(100,20);
        txtResultado.Location= new Point(100,275);

        //Boton Calcular
        btnCalcular= new Button();
        btnCalcular.Text="Calcular";
        btnCalcular.AutoSize=true;
        btnCalcular.Location= new Point(200,200);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);

        //Agregar controles a la ventana
        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculos);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        this.Controls.Add(lblBase);
        this.Controls.Add(txtBase);
        this.Controls.Add(lblLadoA);
        this.Controls.Add(txtLadoA);
        this.Controls.Add(lblLadoB);
        this.Controls.Add(txtLadoB);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
        this.Controls.Add(btnCalcular);

    }
    private void cmb_ValueChanged(object sender, EventArgs e){
        if(cmbCalculos.SelectedIndex!=0 && cmbFiguras.SelectedIndex!=0){
            if(cmbFiguras.SelectedItem.ToString()=="Cuadrado"){
                //cmbFigura.SelectedIndex==1
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                }
            }else if(cmbFiguras.SelectedItem.ToString()=="Triángulo"){
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtBase.Visible=true;
                    lblBase.Visible=true;
                    txtLadoA.Visible=true;
                    lblLadoA.Visible=true;
                    txtLadoB.Visible=true;
                    lblLadoB.Visible=true;
                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible=true;
                    lblBase.Visible=true;
                }
            }else if(cmbFiguras.SelectedItem.ToString()=="Rectángulo"){
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible=true;
                    lblBase.Visible=true;
                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible=true;
                    lblBase.Visible=true;
                }
            }
        }
        else
        {
            txtAltura.Visible=false;
            lblAltura.Visible=false;
            txtBase.Visible=false;
            lblBase.Visible=false;
            txtLadoA.Visible=false;
            lblLadoA.Visible=false;
            txtLadoB.Visible=false;
            lblLadoB.Visible=false;
        }
    }
    private void btnCalcular_Click(object sender, EventArgs e){
        if(cmbCalculos.SelectedIndex!=0 && cmbFiguras.SelectedIndex!=0){
            if(cmbFiguras.SelectedItem.ToString()=="Cuadrado"){
                string calculo= cmbCalculos.SelectedItem.ToString();
                if(txtAltura.Text!=""){
                    if(calculo=="Périmetro"){
                        int altura= Convert.ToInt32(txtAltura.Text);
                        txtResultado.Text=(altura*4).ToString();
                    }
                    if(calculo=="Área"){
                        int altura= Convert.ToInt32(txtAltura.Text);
                        txtResultado.Text=(altura*altura).ToString();
                    }
                }
            }if(cmbFiguras.SelectedItem.ToString()=="Triángulo"){
                if(txtAltura.Text!="" & txtBase.Text!=""){
                    string calculo= cmbCalculos.SelectedItem.ToString();
                    if(calculo=="Périmetro"){
                        int Base = Convert.ToInt32(txtBase.Text);
                        int ladoA= Convert.ToInt32(txtLadoA.Text);
                        int LadoB = Convert.ToInt32(txtLadoB.Text);
                        txtResultado.Text=(Base+LadoB+ladoA).ToString();
                    }
                    if(calculo=="Área"){
                        int altura= Convert.ToInt32(txtAltura.Text);
                        int Base = Convert.ToInt32(txtBase.Text);
                        txtResultado.Text=((altura*Base)/2).ToString();
                    }
                }
            }if(cmbFiguras.SelectedItem.ToString()=="Rectángulo"){
                if(txtAltura.Text!="" & txtBase.Text!=""){
                    string calculo= cmbCalculos.SelectedItem.ToString();
                    if(calculo=="Périmetro"){
                        int altura= Convert.ToInt32(txtAltura.Text);
                        int Base = Convert.ToInt32(txtBase.Text);
                        txtResultado.Text=(2*(altura+Base)).ToString();
                    }
                    if(calculo=="Área"){
                        int altura= Convert.ToInt32(txtAltura.Text);
                        int Base = Convert.ToInt32(txtBase.Text);
                        txtResultado.Text=(altura*Base).ToString();
                    }
                }
            }
        }
    }

}

