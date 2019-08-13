# Identity branch

* cannot modify categories 

* authorization only work for ccreating and viewing tasks

* to limit access to signed-in users, use the authorize attribute
``` c#
[Authorize]
public class ItemsController : Controller
{

}
```