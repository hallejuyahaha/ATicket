using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ATicket.Services
{
    //public class WcfService : IDataStore<List<showstart>>
    //{
    //    private ServiceReference1.Service1Client service1;
    //    public WcfService()
    //    {
    //        var binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
    //        var address = new EndpointAddress("http://localhost:8000/Service1.svc");
    //        ServiceReference1.Service1Client service1 = new ServiceReference1.Service1Client(binding, address);
    //        //ServiceReference1.showstart[] tem = service1.GetShowAsync().Result;
    //    }

    //    public Task<bool> AddItemAsync(List<showstart> item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<bool> DeleteItemAsync(string id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<List<showstart>> GetItemAsync(string id)
    //    {
    //        var task = new TaskCompletionSource<List<showstart>>();

    //        //service1.GetDataCompleted += (sender, e) =>
    //        //{
    //        //    if (e.Cancelled)
    //        //        task.TrySetCanceled();
    //        //    else if (e.Error != null)
    //        //        task.TrySetException(e.Error);
    //        //    else
    //        //        task.TrySetResult(e.Result);
    //        //};
            
    //        service1.GetDataAsync(1);
    //        //service1.GetShowAsync();
    //        return task.Task;
    //    }

    //    public Task<IEnumerable<List<showstart>>> GetItemsAsync(bool forceRefresh = false)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<bool> UpdateItemAsync(List<showstart> item)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
