using BMS_Clone.Enums;
using BMS_Clone.Views.Dialog;

namespace BMS_Clone.Services
{
     public static class ToastService
    {

        public static void Show(
            ToastType type,
            string title,
            string message)
        {

            ToastDialog toast = new(
                type,
                title,
                message
            );


            toast.Show();
        }


        public static void Success(string message)
        {
            Show(
                ToastType.Success,
                "Success",
                message);
        }


        public static void Error(string message)
        {
            Show(
                ToastType.Error,
                "Error",
                message);
        }


        public static void Warning(string message)
        {
            Show(
                ToastType.Warning,
                "Warning",
                message);
        }


        public static void Info(string message)
        {
            Show(
                ToastType.Info,
                "Information",
                message);
        }
    }
}
