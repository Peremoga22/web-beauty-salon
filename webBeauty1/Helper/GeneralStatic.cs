using System.Text;

using webBeauty1.Pages;
namespace webBeauty1.Helper
{
    public  class GeneralStatic
    {
       //Our Services 

        public static string ShowDescription()
        {
            string ourTextServices = string.Empty;
            return   ourTextServices = "Косметологія гармонійно поєднує в собі апаратні методики, препарати, створені на основі сучасних знань лікарів і технології, які вдосконалюються з кожним днем.";
        }


        //Index Cosmetology
        public static string ShowDescriptionsTextCosmetology()
        {
            string ourTextCosmetology = "Чиста і оксамитова шкіра для сучасних дівчат - це запорука успіху, краси і впевненості в собі.";
            return ourTextCosmetology;
        }

        public static string PeelingTextDescription()
        {
            string peelingDescriptionText = "Пілінг допомагає вирішити різноманітні проблеми шкіри, такі як акне постаріння, зморшки, нерівний тон, пігментація, розширені пори і навіть рубці. Він також сприяє покращенню загального стану шкіри та її текстури.";
            return peelingDescriptionText;
        }

        public static string MesotherapyEyesTextDescription()
        {
            string peelingDescriptionText = "Мезотерапія навколо очей - косметологічна процедура, проведення якої полягає у введенні в верхні шари дерми і епідермісу вітамінних сумішей з біоактивними речовинами. Швидкий і максимальний ефект гарантується тим, що точкові ін'єкції вводяться безпосередньо в проблемні зони.";
            return peelingDescriptionText;
        }

        //public static string MesotherapyTextDescription()
        //{
        //    string peelingDescriptionText = "Пілінг допомагає вирішити різноманітні проблеми шкіри, такі як акне постаріння, зморшки, нерівний тон, пігментація, розширені пори і навіть рубці. Він також сприяє покращенню загального стану шкіри та її текстури.";
        //    return peelingDescriptionText;
        //}
    }
      
}
