//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using UnityEngine;
using nh.ui.basePanel;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using nh.ui.mediator;
namespace nh.ui.main
{
	public class InfoPanel : BasePanel
	{

		public GameObject infoLabel;
		public GameObject infoBg;
		void Start()
		{
//			Facade.Instance.RegisterMediator(new InfoPanelMediator(this));

		}
		public void UpdateMessage(string msg)
		{
			infoLabel.GetComponent<UILabel>().text = msg;
			if (this.gameObject != null)
				this.gameObject.SetActive(true);
		}
		void AtEffectFinish()
		{
			this.StartCoroutine(HidePanel());
//			Facade.Instance.SendNotification(NotificationIDs.ID_ShowExpEffectFinish);
		}
		IEnumerator HidePanel()
		{
			yield return true;
			if (this.gameObject != null)
			{		
				infoLabel.transform.position = new Vector3(0, 0, 0);
				infoBg.transform.position = new Vector3(0, 0, 0);
				this.gameObject.SetActive(false);
			}
		}
//		void Update()
//		{
//			if (isShow)
//			{
//				count++;
//				if (count == 100)
//				{
//					this.gameObject.SetActive(false);
//					count = 0;
//					isShow = false;
//				}
//			}
//		}
	}
}

