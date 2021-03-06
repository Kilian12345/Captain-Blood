﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    public abstract class EventsManager : MonoBehaviour
    {
        private void OnEnable()
        {
            GameManager.events.RegisterEntity(this); // Add the entity to the global list of all the entities.
        }

        private void OnDisable()
        {
            GameManager.events.UnregisterEntity(this); // Add the entity to the global list of all the entities.
        }

        public virtual void EventE()
        {

        }

        public virtual void InitializingFTL() { Debug.Log("InitializingFTL"); }
        public virtual void FTLDistortionIn() { Debug.Log("FTLDistortion"); }
        public virtual void FTLDistortionOut() { }
        public virtual void SlowingDown() { Debug.Log("SlowingDown"); }
        public virtual void StartFTL() { Debug.Log("FTLStart"); }


    }

    public class Events
    {
        public List<EventsManager> events = new List<EventsManager>();

        /// <summary>
        /// Register the entities
        /// </summary>
        /// <param name="evnt">Entity you want to register</param>
        public void RegisterEntity(EventsManager evnt)
        {
            events.Add(evnt);
        }

        /// <summary>
        /// Register the entities
        /// </summary>
        /// <param name="ent">Entity you want to unregister</param>
        public void UnregisterEntity(EventsManager evnt)
        {
            events.Remove(evnt);
        }

        public void CallEventE()
        {
            for (int i = 0; i < events.Count; i++)
            {
                events[i].EventE();
            }
        }

        public void CallInitializingFTL()
        {
            for (int i = 0; i < events.Count; i++)
            {
                events[i].InitializingFTL();
            }
        }

        public void CallFTLDistortionIn()
        {
            for (int i = 0; i < events.Count; i++)
            {
                events[i].FTLDistortionIn();
            }
        }

        public void CallFTLDistortionOut()
        {
            for (int i = 0; i < events.Count; i++)
            {
                events[i].FTLDistortionOut();
            }
        }

        public void CallSlowingDown()
        {
            for (int i = 0; i < events.Count; i++)
            {
                events[i].SlowingDown();
            }
        }

        public void CallStartFTL()
        {
            for (int i = 0; i < events.Count; i++)
            {
                events[i].StartFTL();
            }
        }
    }

}