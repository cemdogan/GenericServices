using GenericServices.Core;

namespace GenericServices.Services
{
    
    public interface ICreateService<in TData> where TData : class
    {

        /// <summary>
        /// This adds a new entity class to the database with error checking
        /// </summary>
        /// <param name="newItem"></param>
        /// <returns>status</returns>
        ISuccessOrErrors Create(TData newItem);
    }

    public interface ICreateService<TData, TDto>
        where TData : class, new()
        where TDto : EfGenericDto<TData, TDto>
    {
        /// <summary>
        /// This uses a dto to create a data class which it writes to the database with error checking
        /// </summary>
        /// <param name="dto">If an error then its resets any secondary data so that you can reshow the dto</param>
        /// <returns>status</returns>
        ISuccessOrErrors Create(TDto dto);

        /// <summary>
        /// This is available to reset any secondary data in the dto. Call this if the ModelState was invalid and
        /// you need to display the view again with errors
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        TDto ResetDto(TDto dto);
    }
}