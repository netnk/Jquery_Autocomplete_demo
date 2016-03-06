$(document).ready(function () {
  search_autotext();
  
});


function search_autotext_title() {
    $("#search_title").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "booklist.ashx",
                dataType: "json",
                data: {
                    method: "search_autotext_title", term: request.term     
                },
                success: function (data) {                   
                    response($.map(data, function (item) {
                        return {
                            value: item      
                        }
                    }));
                }
            });
        },
     
    });
}
