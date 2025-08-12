set_project("swiftlys2")
set_version("1.0.0")
set_languages("c++17")

add_rules("mode.debug", "mode.release")

add_includedirs("include")
add_includedirs("external/include")

target("swiftlys2")
    set_kind("shared")
    add_files("src/*.cpp")