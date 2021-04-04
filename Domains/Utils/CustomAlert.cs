using CurrieTechnologies.Razor.SweetAlert2;

namespace FatecMauaJobNewsletter.Domains.Utils
{
    public static class CustomAlert
    {
        public static SweetAlertOptions Alert(string title, string text = null)
        {
            return new SweetAlertOptions
            {
                Title = title,
                Text = text,
                ShowCancelButton = true,
                ConfirmButtonText = "Sim",
                CancelButtonText = "Não"
            };
        }
    }
}
