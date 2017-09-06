using Android.App;
using Android.Widget;
using Android.OS;

namespace Aula1
{
    [Activity(Label = "Aula1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //Os componentes no arquivo axml não são visíveis aqui, portanto, é necessário instânciá-los

        //Criando as variáveis para instanciar os objetos do layout (arquivo axml Main),
        TextView tvMensagem; //não é necessário escrever o mesmo nome do id no arquivo axml
        Button btnOkay;
        AutoCompleteTextView tfNome;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            //Explica à qual layout esta página de código irá pertencer
            SetContentView (Resource.Layout.Main);

            //Instânciando os componentes
            tvMensagem = (TextView)FindViewById(Resource.Id.tvMensagem);
            btnOkay = (Button)FindViewById(Resource.Id.btnOkay);
            tfNome = (AutoCompleteTextView)FindViewById(Resource.Id.tfNome);

            //nome da variável criada = (aquilo que quer converter - componente que vai ser convertido na axml).FindViewbyId(Resource.Id.id do obj)
            //FindViewById - busca componentes pela Id

            //Criando o método de clique
            btnOkay.Click += BtnOkay_Click;
            //Adicionando à ação do botão +- um método chamada btnOkay_Click 
        }

        private void BtnOkay_Click(object sender, System.EventArgs e)
        {
            string nome;
            nome = tfNome.Text;

            tvMensagem.Text = "Bem vindo ao Xamarin, " + nome + "!";
        }
    }
}

