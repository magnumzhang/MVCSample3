function ajax_call_action(ActionURL, JSonPostDataStr, CallBackMethod) {
    $.ajax({
        url: ActionURL,
        async: false,
        type: "POST",
        data: {
            JSonPostDataStr
        },
        success: function (data) {
            CallBackMethod(data);
        }
    });
}

 