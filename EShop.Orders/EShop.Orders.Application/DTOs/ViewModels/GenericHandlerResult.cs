namespace EShop.Orders.Application.DTOs.ViewModels
{
    public class GenericHandlerResult<T> where T : class
    {
        public GenericHandlerResult(string message, T date, bool sucess, List<ValidationObject> validations)
        {
            Message = message;
            Date = date;
            Sucess = sucess;
            Validations = validations;
        }

        public string Message { get; private set; }
        public T Date { get; private set; }
        public bool Sucess { get; private set; }
        public List<ValidationObject> Validations { get; private set; }
    }

    public class ValidationObject
    {
        public ValidationObject(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; private set; }
        public string Message { get; private set; }

    }
}
