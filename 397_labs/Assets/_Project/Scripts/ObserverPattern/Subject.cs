using System.Collections.Generic;
using UnityEngine;

namespace WebGame397
{
    public abstract class Subject : MonoBehaviour
    {
        //List of Observers
        //Add and/or remove observers from list
        //Notification method to notify observers

        [SerializeField] private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer) => observers.Add(observer);
        public void RemoveObserver(IObserver observer) => observers.Remove(observer);
        public void NotifyObservers()
        {
            foreach(IObserver observer in observers)
            {
                observer.OnNotify();
            }
        }
    }
}
