// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('#TableTasks').DataTable({
        "columnDefs": [
            { orderable: false, targets: 6 }
        ],
        "scrolly": "450px",
        "scrollcollapse": true,
        "paging": true
    });
});
$(document).ready(function () {
    $('#TablePriorities').DataTable({
        "columnDefs": [
            { orderable: false, targets: 1 }
        ],
        "scrolly": "450px",
        "scrollcollapse": true,
        "paging": true
    });
});