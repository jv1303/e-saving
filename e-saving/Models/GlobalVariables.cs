namespace variables.Models
{
    public class GlobalVariables
    {
        public string userLogged {get; set;}
    }

    public static class RepositorioGlobalVariables
    {

        public static GlobalVariables Variables = new GlobalVariables {
            userLogged = "false"
        };
        public static string SwitchUserLogged()
        {
            var variable = Variables;

            if (variable.userLogged == "false") {
                variable.userLogged = "true";
            } else {
                variable.userLogged = "false";
            }

            return variable.userLogged;
        }


    }
}