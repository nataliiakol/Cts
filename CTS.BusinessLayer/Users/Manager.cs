namespace CTS.BusinessLayer.Users
{
    public class Manager : SystemUser {

        private static Manager vInstance;

        protected Manager() {
            
        }

        public static Manager Instance() {
            if (vInstance == null) {
                vInstance = new Manager();
            }
            return vInstance;
        }
    }
}
