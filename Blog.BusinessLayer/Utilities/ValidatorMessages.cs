namespace Blog.BusinessLayer.Utilities
{
    public class ValidatorMessages
    {
        public string NotEmpty { get; } = " boş geçilmemelidir.";
        public string NotSmaller { get; } = " karakterden küçük olmamalıdır.";
        public string NotBigger { get; } = " karakterden büyük olmamalıdır.";
        public string ValidFormat { get; } = " uygun formatta olmalıdır.";
    }
}
