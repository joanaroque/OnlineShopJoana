using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopCET46.WEB.Data;
using ShopCET46.WEB.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCET46.WEB.Controllers
{
    public class ProductsController : Controller  // controlador so serve pras views | vem tudo do IRepository
    {
<<<<<<< HEAD
        private readonly IRepository _repository;

        public ProductsController(IRepository repository)
        {
            this._repository = repository;
=======
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
>>>>>>> seed_db
        }

        // GET: Products
        public IActionResult Index()
        {
<<<<<<< HEAD
            return View(_repository.GetProducts());
=======
            return View(_productRepository.GetAll());
>>>>>>> seed_db
        }

        // GET: Products/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            var product = _repository.GetProduct(id.Value);//precisa o value para conseguir compilar

=======
            var product = _productRepository.GetByIdAsync(id.Value);
                
>>>>>>> seed_db
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
<<<<<<< HEAD
                _repository.AddProduct(product);
                await _repository.SaveAllAsync();
=======
                await _productRepository.CreateAsync(product);
               
>>>>>>> seed_db
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            var product = _repository.GetProduct(id.Value);

=======
            var product = await _productRepository.GetByIdAsync(id.Value);
>>>>>>> seed_db
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
<<<<<<< HEAD
                    _repository.UpdateProduct(product);
                    await _repository.SaveAllAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_repository.ProductExists(product.ProductId))
=======
                    await _productRepository.UpdateAsync(product);
                   
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _productRepository.ExistAsync(product.ProductId))
>>>>>>> seed_db
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            var product = _repository.GetProduct(id.Value); 

=======
            var product = await _productRepository.GetByIdAsync(id.Value);
              
>>>>>>> seed_db
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
<<<<<<< HEAD
            var product = _repository.GetProduct(id);
            _repository.RemoveProduct(product);

            await _repository.SaveAllAsync();
=======
            var product = await _productRepository.GetByIdAsync(id);
            await _productRepository.DeleteAsync(product);
           
>>>>>>> seed_db
            return RedirectToAction(nameof(Index));
        }
    }
}
