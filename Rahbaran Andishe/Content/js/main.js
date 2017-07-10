new WOW().init();

$('.gallery-slider').flickity({
    // options
    cellAlign: 'left',
    contain: true,
    pageDots: false,
    draggable: false

});

$(document).ready(function () {
    $(".img img").on('click',function () {
        $("#gallery-modal").modal({
            show:true
        })
        var mysrc=this.src;
        $("#modal-img").attr('src',mysrc);
    })
})

