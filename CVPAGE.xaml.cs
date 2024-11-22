using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;
namespace DBP_Cv_Form_ultimo;

public partial class CVFormPage : ContentPage
{
    public CVFormPage()
    {
        InitializeComponent();
    }

    private void OnGenerateCVButtonClicked(object sender, EventArgs e)
    {
        // Obtener los datos del formulario
        string name = NameEntry.Text?.Trim();
        string age = AgeEntry.Text?.Trim();
        string occupation = OccupationEntry.Text?.Trim();
        string address = AddressEntry.Text?.Trim();

        // Validar que los campos no estén vacíos
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(age) ||
            string.IsNullOrWhiteSpace(occupation) || string.IsNullOrWhiteSpace(address))
        {
            DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
            return;
        }

        // Crear el texto del CV
        string cvText = $"--- CURRICULUM VITAE ---\n\n" +
                        $"Nombre: {name}\n" +
                        $"Edad: {age}\n" +
                        $"Ocupación: {occupation}\n" +
                        $"Dirección: {address}\n";

        // Mostrar el CV en la etiqueta
        CVLabel.Text = cvText;
    }
}
