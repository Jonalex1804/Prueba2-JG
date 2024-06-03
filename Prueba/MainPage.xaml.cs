namespace Prueba
{
    public partial class MainPage : ContentPage
    {
        private int selectedAmount = 5;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAmountChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                var radioButton = sender as RadioButton;
                selectedAmount = int.Parse(radioButton.Value.ToString());
                lblSelectedAmount.Text = $"Ha seleccionado una recarga de: {selectedAmount} dólares";
            }
        }

        private async void OnRechargeClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Confirmación", $"¿Desea recargar {selectedAmount} dólares?", "Sí", "No");
            if (confirm)
            {
                string phoneNumber = entPhoneNumber.Text;
                string operatorName = pickerOperator.SelectedItem.ToString();
                string rechargeDetails = $"Se hizo una recarga de {selectedAmount} dólares en la siguiente fecha; {DateTime.Now.ToString("dd/MM/yyyy")}";

                // Guardar la información en un archivo
                // string filePath = Path.Combine(FileSystem.AppDataDirectory, $"{phoneNumber}.txt");
                //File.WriteAllText(filePath, rechargeDetails);

                //  await DisplayAlert("Finalizado", "Recarga exitosa", "OK");


            }
        }
    }


}