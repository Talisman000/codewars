#!/bin/sh -eu

IsAvailableLanguage() {
    case "$1" in
    "cpp")
        echo "true"
        return 0
        ;;
    "cs")
        echo "true"
        return 0
        ;;
    "git")
        echo "true"
        return 0
        ;;
    esac
    echo "false"
}

InitDirectory() {
    if [ ! -e $1 ]; then
        mkdir $1
    fi
}

CreateProject() {
    local directoryCpp="cpp"
    local directoryCsharp="csharp"
    case "$2" in
    "cpp")
        InitDirectory $directoryCpp
        cd $directoryCpp
        InitDirectory $1
        cd $1
        touch main.cpp
        ;;
    "cs")
        InitDirectory $directoryCsharp
        cd $directoryCsharp
        InitDirectory $1
        cd $1
        dotnet new console
        touch Kata.cs
        ;;
    "git")
        git add .
        git commit -m "Update solution of $1"
        git push
        ;;
    esac
}

main() {
    while :; do
        echo -n "Project Name:"
        read projectName
        if [ "$projectName" != "" ]; then
            break
        fi
    done

    while :; do
        echo -n "Language(cpp(C++)/cs(C#)/git(push solution)):"
        read language
        if [ "$language" = "" ]; then
            continue
        fi
        local isAvailable=$(IsAvailableLanguage $language)
        if [ "$isAvailable" = "true" ]; then
            break
        fi
    done
    CreateProject $projectName $language
    return 0
}

main
