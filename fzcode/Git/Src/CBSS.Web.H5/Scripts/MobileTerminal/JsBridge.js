﻿//检测系统
function checkPlatform() {
    console.log("checkPlatform");
    var system =
    {
        win: false,
        mac: false,
        xll: false
    };
    //检测平台    
    var p = navigator.platform;

    system.win = p.indexOf("Win") == 0;
    system.mac = p.indexOf("Mac") == 0;
    system.x11 = (p == "X11") || (p.indexOf("Linux") == 0);
    //跳转语句    
    if (system.win || system.mac || system.xll) {
        console.log("PC端");
        return 0;
    }
    else {
        if (navigator.userAgent.indexOf("Mac") < 0) {
            console.log("安卓端");
            return 1;
        }
        else {
            console.log("苹果端");
            return 2;
        }

    }
}

/*与OC交互的所有JS方法都要放在此处注册，才能调用通过JS调用OC或者让OC调用这里的JS*/
//添加 callback
function setupWebViewJavascriptBridge(callback) {
    if (window.WebViewJavascriptBridge) { return callback(WebViewJavascriptBridge); }

    if (checkPlatform() == 1) {
        document.addEventListener('WebViewJavascriptBridgeReady', function () {
            callback(WebViewJavascriptBridge);
        }, false);
        return;
    }

    if (window.WVJBCallbacks) { return window.WVJBCallbacks.push(callback); }
    window.WVJBCallbacks = [callback];
    var WVJBIframe = document.createElement('iframe');
    WVJBIframe.style.display = 'none';
    WVJBIframe.src = 'wvjbscheme://__BRIDGE_LOADED__';
    document.documentElement.appendChild(WVJBIframe);
    setTimeout(function () { document.documentElement.removeChild(WVJBIframe) }, 0);
}
setupWebViewJavascriptBridge(function (bridge) {

    if (checkPlatform() == 1) {
        bridge.init(function (message, responseCallback) {
            log('JS got a message', message);
            var data = { 'Javascript Responds': 'Wee!' };
            log('JS responding with', data);
            responseCallback(data);
        });
    }

    //bridge.registerHandler('startWebPage', function (data, responseData) {
    //    console.log(data);
    //    var url;
    //    if (data != undefined) {
    //        url = "";
    //        var udata = JSON.parse(data);
    //        var userid = udata.UserId;
    //        var result = UserinfoManage.StarPageByUserId(userid);
    //        if (result.Success) {
    //            localStorage.clear();
    //            localStorage["UserId"] = data;
    //            var dataresult = result.Data;
    //            switch ((dataresult - 0)) {
    //                case 0:
    //                    url = "beforeactivity.aspx"; //未到报名时间
    //                    break;
    //                case 1:
    //                    url = "registration.aspx?userid=" + userid + ""; //比赛未开始 未报名
    //                    break;
    //                case 2:
    //                case 3:
    //                    url = "registfinish.aspx?error=0"; //已报名
    //                    break;
    //                case 4:
    //                    url = "registfinish.aspx?error=1"; //未报名
    //                    break;
    //                case 5:
    //                    url = "stargame.aspx?userid=" + userid + "";
    //                    break;
    //                case 6:
    //                    url = "registfinish.aspx?error=1";
    //                    break;
    //                default:
    //                    url = "registfinish.aspx?error=1"; //无状态
    //                    break;
    //            }
    //            //打开页面
    //            window.location.href = url;
    //            responseCallback({ 'Success': true, 'data': url, 'Message': "" });
    //            //window.location.href = url;
    //        }
    //    }
    //    //responseCallback({ 'Success' : true, 'data' : url, 'Message' : ""  });
    //});


});


function Finish() {
    //send message to native
    var data = {};
    window.WebViewJavascriptBridge.callHandler(
        'finishPage', data, function (responseData) {

        }
    );
}