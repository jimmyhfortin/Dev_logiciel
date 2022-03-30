jQuery("#simulation")
  .on("pageload", ".s-d12245cc-1680-458d-89dd-4f0d7fb22724 .pageload", function(event, data) {
    var jEvent, jFirer, cases;
    if(jimUtil.isAlternateModeActive()) return;
    if(data === undefined) { data = event; }
    jEvent = jimEvent(event);
    jFirer = jEvent.getEventFirer();
    if(jFirer.is("#s-Image")) {
      cases = [
        {
          "blocks": [
            {
              "actions": [
                {
                  "action": "jimPause",
                  "parameter": {
                    "pause": 1000
                  },
                  "exectype": "serial",
                  "delay": 0
                }
              ]
            }
          ],
          "exectype": "serial",
          "delay": 0
        },
        {
          "blocks": [
            {
              "actions": [
                {
                  "action": "jimShow",
                  "parameter": {
                    "target": [ "#s-Image" ],
                    "effect": {
                      "type": "fade",
                      "duration": 500
                    }
                  },
                  "exectype": "serial",
                  "delay": 0
                },
                {
                  "action": "jimMove",
                  "parameter": {
                    "target": [ "#s-Image" ],
                    "top": {
                      "type": "movetoposition",
                      "value": "158.0"
                    },
                    "left": {
                      "type": "movebyoffset",
                      "value": "600.0"
                    },
                    "containment": false,
                    "effect": {
                      "type": "none",
                      "easing": "linear",
                      "duration": 1500
                    }
                  },
                  "exectype": "serial",
                  "delay": 0
                },
                {
                  "action": "jimShow",
                  "parameter": {
                    "target": [ "#s-Image" ],
                    "effect": {
                      "type": "pulsate",
                      "duration": 200
                    }
                  },
                  "exectype": "serial",
                  "delay": 0
                }
              ]
            }
          ],
          "exectype": "serial",
          "delay": 0
        },
        {
          "blocks": [
            {
              "actions": [
                {
                  "action": "jimSetValue",
                  "parameter": {
                    "target": [ "#s-Image" ],
                    "value": "./images/bab31513-c08c-473f-aa83-f45c2541a3aa.png"
                  },
                  "exectype": "serial",
                  "delay": 0
                },
                {
                  "action": "jimMove",
                  "parameter": {
                    "target": [ "#s-Image" ],
                    "top": {
                      "type": "movebyoffset",
                      "value": "0.0"
                    },
                    "left": {
                      "type": "movetoposition",
                      "value": "95.0"
                    },
                    "containment": false,
                    "effect": {
                      "type": "none",
                      "easing": "linear",
                      "duration": 2000
                    }
                  },
                  "exectype": "serial",
                  "delay": 0
                },
                {
                  "action": "jimSetValue",
                  "parameter": {
                    "target": [ "#s-Image" ],
                    "value": "./images/4ab67b4d-b2e3-4390-871c-9f104f23c670.png"
                  },
                  "exectype": "serial",
                  "delay": 0
                }
              ]
            }
          ],
          "exectype": "serial",
          "delay": 0
        },
        {
          "blocks": [
            {
              "actions": [
                {
                  "action": "jimPause",
                  "parameter": {
                    "pause": 1000
                  },
                  "exectype": "serial",
                  "delay": 0
                }
              ]
            }
          ],
          "exectype": "serial",
          "delay": 0
        },
        {
          "blocks": [
            {
              "actions": [
                {
                  "action": "jimShow",
                  "parameter": {
                    "target": [ "#s-Image" ],
                    "effect": {
                      "type": "fade",
                      "duration": 500
                    }
                  },
                  "exectype": "serial",
                  "delay": 0
                },
                {
                  "action": "jimMove",
                  "parameter": {
                    "target": [ "#s-Image" ],
                    "top": {
                      "type": "movetoposition",
                      "value": "158.0"
                    },
                    "left": {
                      "type": "movebyoffset",
                      "value": "600.0"
                    },
                    "containment": false,
                    "effect": {
                      "type": "none",
                      "easing": "linear",
                      "duration": 1500
                    }
                  },
                  "exectype": "serial",
                  "delay": 0
                },
                {
                  "action": "jimShow",
                  "parameter": {
                    "target": [ "#s-Image" ],
                    "effect": {
                      "type": "pulsate",
                      "duration": 200
                    }
                  },
                  "exectype": "serial",
                  "delay": 0
                }
              ]
            }
          ],
          "exectype": "serial",
          "delay": 0
        },
        {
          "blocks": [
            {
              "actions": [
                {
                  "action": "jimSetValue",
                  "parameter": {
                    "target": [ "#s-Image" ],
                    "value": "./images/bab31513-c08c-473f-aa83-f45c2541a3aa.png"
                  },
                  "exectype": "serial",
                  "delay": 0
                },
                {
                  "action": "jimMove",
                  "parameter": {
                    "target": [ "#s-Image" ],
                    "top": {
                      "type": "movebyoffset",
                      "value": "0.0"
                    },
                    "left": {
                      "type": "movetoposition",
                      "value": "95.0"
                    },
                    "containment": false,
                    "effect": {
                      "type": "none",
                      "easing": "linear",
                      "duration": 2000
                    }
                  },
                  "exectype": "serial",
                  "delay": 0
                },
                {
                  "action": "jimSetValue",
                  "parameter": {
                    "target": [ "#s-Image" ],
                    "value": "./images/4ab67b4d-b2e3-4390-871c-9f104f23c670.png"
                  },
                  "exectype": "serial",
                  "delay": 0
                }
              ]
            }
          ],
          "exectype": "serial",
          "delay": 0
        }
      ];
      event.data = data;
      jEvent.launchCases(cases);
    }
  });