using CaseBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
	public class EditCategoryUseCase
	{
		public EditCategoryUseCase(ICategoryRepository categoryRepository)
		{
			CategoryRepository = categoryRepository;
		}

		public ICategoryRepository CategoryRepository { get; }

		public void Execute(Category category)
		{

		}
	}
}
