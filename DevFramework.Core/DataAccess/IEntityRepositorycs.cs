using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess
{
	public interface IEntityRepositorycs<T>
	{
		List<T> GetList(Expression<Func<T, bool>> filter = null);
	}
}
