import Link from 'next/link'
import Image from 'next/image'
import React from 'react'

const menuItems = [
  {
    link: '/about',
    menuText: 'About Me',
    styleText: ''
  },
  {
    link: '/resume',
    menuText: 'Resume',
    styleText: ''
  },
  {
    link: '/contact',
    menuText: 'Contact Me',
    styleText: ''
  }
]

export default function Navigation () {
  return (
    <nav className="container-fluid px-4 mx-auto bg-mountain-mist-500">
      <div className="flex flex-row md:justify-between items-center">
        <div>
        <Link href={'/'}>
          <Image
            src={'/img/newlogoresized.png'}
            alt="code prodigy logo"
            width="80"
            height="75"
          />
        </Link>
        </div>
        <div className="text-stone-300 p-4 ">
          {menuItems.map((menuItem) => (
            <span
              key={`${new Date()}-${menuItem.menuText}`}
              className={"p-5 md:text-xl hover:text-old-brick-400 hover:underline hover:underline-offset-8 decoration-wavy hover:cursor-pointer"}
            >
            <Link href={menuItem.link}>
              {menuItem.menuText}
            </Link>
          </span>
          ))}
        </div>
      </div>
    </nav>
  )
}