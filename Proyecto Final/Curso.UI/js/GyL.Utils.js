var GyL = GyL || {};
GyL.Utils = GyL.Utils || {};
$.extend(true, GyL.Utils, {
    Tools: (function () { //Singleton
        return {
            ajax: function (url, data, success)
            {
                $.ajax({
                    type: 'POST',
                    url: url,
                    data: data,
                    contentType: "application/json;charset=utf-8",
                    dataType: "json",
                    success: success,
                    error: function (jqXHR, exception) {
                        var msg = '';
                        if (jqXHR.status === 0) {
                            msg = 'Not connect.\n Verify Network.';
                        } else if (jqXHR.status == 404) {
                            msg = 'Requested page not found. [404]';
                        } else if (jqXHR.status == 500) {
                            msg = 'Internal Server Error [500].';
                        } else if (exception === 'parsererror') {
                            msg = 'Requested JSON parse failed.';
                        } else if (exception === 'timeout') {
                            msg = 'Time out error.';
                        } else if (exception === 'abort') {
                            msg = 'Ajax request aborted.';
                        } else {
                            msg = 'Uncaught Error.\n' + jqXHR.responseText;
                        }
                        alert(msg);
                    }
                });
            }
        }
    })()
});