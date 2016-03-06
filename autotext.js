$(document).ready(function () {
  search_autotext();
  
});



function search_autotext() {
    $.ajax({ 
        url: "demo.ashx",
        data: { method: "search_autotext" },
                type: "POST",
                dataType: "text",
                success: function (data) { 
                  var test1 = JSON.parse(data);
                  $("#search_text").autocomplete({
                      source: test1
                     });
                }
    });
}
