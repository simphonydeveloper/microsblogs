using Micros.Ops;
using Micros.PosCore.Extensibility;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimphonyExample
{
    public partial class SimphonyExampleApplication
    {
        [ExtensibilityMethod]
        public void Part18Test1()
        {
            Logger.LogAlways("Part18Test1");

           string[] names = Enum.GetNames(typeof(DialogType));

            var typeSelection = this.OpsContext.SelectionRequest("Select Dialog", "Show your dialog", names);

            if (!typeSelection.HasValue)
                return;
            string selection = names[typeSelection.Value];
            var dialogType = (DialogType)Enum.Parse(typeof(DialogType), selection);



            List<OpsSelectionEntry> selectionEntries = new List<OpsSelectionEntry>();
            selectionEntries.Add(new OpsSelectionEntry(1, "Selection1"));
            selectionEntries.Add(new OpsSelectionEntry(2, "Selection2"));
            selectionEntries.Add(new OpsSelectionEntry(3, "Selection3"));
            selectionEntries.Add(new OpsSelectionEntry(4, "Selection4"));
            selectionEntries.Add(new OpsSelectionEntry(5, "Selection5"));

            switch (dialogType)
            {
                case DialogType.AskQuestion:
                    this.OpsContext.AskQuestion("AskQuestion Dialog");
                    break;
                case DialogType.MultiSelectionRequest:
                    this.OpsContext.MultiSelectionRequest(DialogType.MultiSelectionRequest, DialogType.MultiSelectionRequest, selectionEntries);
                    break;
                case DialogType.RequestAlphaEntry:
                    this.OpsContext.RequestAlphaEntry("RequestAlphaEntry Message", "RequestAlphaEntry Title");
                    break;
                case DialogType.RequestAmountEntry:
                    {
                        var value = this.OpsContext.RequestAmountEntry("RequestAmountEntry Message", "RequestAmountEntry Title", 1);
                        this.OpsContext.ShowMessage(value.ToString());
                    }
                    break;
                case DialogType.RequestEntry:
                    this.OpsContext.RequestEntry(new Micros.Ops.Input.RequestEntryParameters
                    {
                        Title = "RequestEntry Sample Title",
                        AllowManualEntry = true,
                        Prompt = "RequestEntry Sample Prompt",
                    });
                    break;
                case DialogType.RequestNumericEntry:
                    {
                        var value = this.OpsContext.RequestNumericEntry("RequestNumericEntry Message", "RequestNumericEntry Title", 2);
                        this.OpsContext.ShowMessage(value.ToString());
                    }
                    break;
                case DialogType.RequestStringEntry:
                    this.OpsContext.RequestStringEntry("RequestStringEntry Message", "RequestStringEntry Title");
                    break;
                case DialogType.SearchRequest:
                    this.OpsContext.SearchRequest("SearchRequest Message", "SearchRequest Prompt", selectionEntries);
                    break;
                case DialogType.SelectionRequest:
                    this.OpsContext.SelectionRequest("SelectionRequest Message", "SelectionRequest Prompt", selectionEntries);
                    break;
                case DialogType.ShowError:
                    this.OpsContext.ShowError("Show Error");
                    break;
                case DialogType.ShowException:
                    try
                    {
                        throw new Exception("you can't sleep");
                    }
                    catch (Exception ex)
                    {
                        this.OpsContext.ShowException(ex, "ShowException");
                    }
                    break;
                case DialogType.ShowMessage:
                    this.OpsContext.ShowMessage("a message");
                    break;
                case DialogType.ShowTextList:
                    List<string> texts = new List<string>();
                    texts.Add("Simphony Developer");
                    texts.Add("Very good person");
                    this.OpsContext.ShowTextList("ShowTextList Title", texts);
                    break;
                case DialogType.SimRequestAmountEntry:
                    {
                        var value = this.OpsContext.SimRequestAmountEntry("SimRequestAmountEntry Message", "SimRequestAmountEntry Title", 1);
                        this.OpsContext.ShowMessage(value.ToString());
                    }
                    break;
                case DialogType.SimRequestNumericEntry:
                    {
                        var value = this.OpsContext.SimRequestNumericEntry("SimRequestNumericEntry Message", "SimRequestNumericEntry Title", 2);
                        this.OpsContext.ShowMessage(value.ToString());
                    }
                    break;
                case DialogType.SimSelectionRequest:
                    this.OpsContext.SimSelectionRequest("SimSelectionRequest Message", "SimSelectionRequest Prompt", names);
                    break;
                case DialogType.StartProgressRequest:
                    this.OpsContext.StartProgressRequest("Start Progress Title", "Loading...",100);
                    this.OpsContext.UpdateProgressRequest("Loading...", 20);
                    Thread.Sleep(3000);
                    this.OpsContext.UpdateProgressRequest("Loading...", 50);
                    Thread.Sleep(3000);
                    this.OpsContext.UpdateProgressRequest("Loading...", 70);
                    Thread.Sleep(3000);
                    this.OpsContext.UpdateProgressRequest("Loading...", 100);
                    Thread.Sleep(3000);
                    this.OpsContext.EndProgressRequest();

                    break;
                case DialogType.UpdateProgressRequest:
                    break;
                case DialogType.EndProgressRequest:
                    break;
                default:
                    break;
            }
        }
    }

    public enum DialogType
    {
        AskQuestion,
        MultiSelectionRequest,
        RequestAlphaEntry,
        RequestAmountEntry,
        RequestEntry,
        RequestNumericEntry,
        RequestStringEntry,
        SearchRequest,
        SelectionRequest,
        ShowError,
        ShowException,
        ShowMessage,
        ShowTextList,
        SimRequestAmountEntry,
        SimRequestNumericEntry,
        SimSelectionRequest,
        StartProgressRequest,
        UpdateProgressRequest,
        EndProgressRequest
    }
}
