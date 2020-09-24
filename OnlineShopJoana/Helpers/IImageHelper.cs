using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ShopCET46.WEB.Helpers
{
    public interface IImageHelper
    {
      Task<string> UploadImageAsync(IFormFile imagefile, string folder);
    }
}
