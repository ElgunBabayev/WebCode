$(document).ready(function () {
  updateNav();
  $(window).on("scroll", function () {
    updateNav();
  });

  function updateNav() {
    if ($(window).scrollTop()) {
      $(".navbar").addClass("active");
    } else {
      $(".navbar").removeClass("active");
    }
  }

  $(".owl-carousel").owlCarousel({
    loop: true,
    autoplay: true,
    autoplayTimeout: 4000,
    autoplayHoverPause: true,
    items: 1,
  });

    $(".group-button-item").on("click", function () {
    $(".group-wrapper").addClass("d-none");
    var selector = $(this).data("filter");
    $("."+selector).removeClass("d-none");
  });
});
