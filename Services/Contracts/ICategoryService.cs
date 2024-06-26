﻿using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync(bool trackChanges);
        Task<CategoryDto> GetOneCategoryByIdAsync(int id, bool trackChanges);
        
        Task<CategoryDto> FormOneCategoryAsync(CategoryDtoForInsertion categoryDtoForInsertion);
        Task UpdateOneCategoryAsync(int id, CategoryDtoForUpdate categoryDtoForUpdate, bool trackChanges);
        Task DeleteOneCategoryAsync(int id, bool trackChanges); 
    }
}
